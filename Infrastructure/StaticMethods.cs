using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using System.Data.Linq;
using Microsoft.Data.SqlClient;

namespace SQL_Multi_Flow.Infrastructure
{
    public static class StaticMethods
    {
        #region nestedClasses
        class nestedServer
        {
            public string ServerDomainName { get; set; }
            public string DataBaseName { get; set; }
            public string ServerLogin { get; set; }
            public string ServerPassword { get; set; }
        }

        class nestedPackage
        {
            public nestedServer Server { get; set; }
            public Dictionary<string, string> Scripts { get; set; }
        }

        class nestedScriptsContent
        {
            public string ScriptName { get; set; }
            public string ScriptContent { get; set; }
        }

        class nestedRaportsCompleate
        {
            public int ID { get; set; }
            public DateTime DataTime { get; set; }
            public string ServerDBUserPasswd { get; set; }
            public string ScriptName { get; set; }
        }

        class nestedRaportsInfo
        {
            public int ID { get; set; }
            public DateTime DataTime { get; set; }
            public string ServerDB { get; set; }
            public string Script { get; set; }
            public string MessageInfo { get; set; }
        }

        class nestedRaportsErrors
        {
            public int ID { get; set; }
            public DateTime DataTime { get; set; }
            public string ServerDBUserPasswd { get; set; }
            public string ScriptName { get; set; }
            public int ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }
        #endregion nestedClasses

        #region ShowResults
        public static async Task ShowResults(string connectionString, ListView listViewCompleate, ListView listViewInfo, ListView listViewErrorsSQL, ListView listViewServers)
        {
            await Task.Run(() =>
            {
                DataContext compleateContext = new DataContext(connectionString);
                List<nestedRaportsCompleate> compleateList = new List<nestedRaportsCompleate>();

                DataContext infoContext = new DataContext(connectionString);
                List<nestedRaportsInfo> infoList = new List<nestedRaportsInfo>();

                DataContext errorsContext = new DataContext(connectionString);
                List<nestedRaportsErrors> errorsList = new List<nestedRaportsErrors>();

                List<ListViewItem> viewItems = new List<ListViewItem>();

                DataContext serversContext = new DataContext(connectionString);

                compleateList = compleateContext.ExecuteQuery<nestedRaportsCompleate>("SELECT c.ID, c.DataTime, c.ServerDBUserPasswd, c.ScriptName FROM Raports.Compleate c").ToList();

                infoList = infoContext.ExecuteQuery<nestedRaportsInfo>("SELECT i.ID, i.DataTime, i.ServerDB, i.Script, i.MessageInfo FROM RushDataBasesServersList.Raports.Info i").ToList();

                errorsList = errorsContext.ExecuteQuery<nestedRaportsErrors>("SELECT e.ID, e.DataTime, e.ServerDBUserPasswd, e.ScriptName, e.ErrorCode, e.ErrorMessage FROM RushDataBasesServersList.Raports.Errors e").ToList();

                foreach (var i in compleateList)
                {
                    viewItems.Add(new ListViewItem(new string[] {i.ID.ToString(), i.DataTime.ToString(), i.ServerDBUserPasswd.ToString(), i.ScriptName.ToString()}));
                }

                listViewCompleate.Items.Clear();
                listViewCompleate.Items.AddRange(viewItems.ToArray());
                viewItems.Clear();

                foreach (var i in infoList)
                {
                    viewItems.Add(new ListViewItem(new string[] {i.ID.ToString(), i.DataTime.ToString(), i.ServerDB.ToString(), i.Script.ToString(), i.MessageInfo.ToString()}));
                }

                listViewInfo.Items.Clear();
                listViewInfo.Items.AddRange(viewItems.ToArray());
                viewItems.Clear();

                foreach (var i in errorsList)
                {
                    viewItems.Add(new ListViewItem(new string[] {i.ID.ToString(), i.DataTime.ToString(), i.ServerDBUserPasswd.ToString(), i.ScriptName.ToString(), i.ErrorCode.ToString(), i.ErrorMessage.ToString()}));
                }
                listViewErrorsSQL.Items.Clear();
                listViewErrorsSQL.Items.AddRange(viewItems.ToArray());
                viewItems.Clear();

                var serversList = serversContext.ExecuteQuery<string>("SELECT DISTINCT c.ServerDBUserPasswd FROM Raports.Compleate c");
                foreach (var i in serversList)
                {
                    viewItems.Add(new ListViewItem(i));
                }

                listViewServers.Items.Clear();
                listViewServers.Items.AddRange(viewItems.ToArray());
                viewItems.Clear();

            });

        }


        #endregion ShowResults

        #region ClearRaports
        public static async Task ClearRaports(string connectionString, params ListView[] ps)
        {
            await Task.Run(() =>
            {
                foreach (var i in ps)
                {
                    i.Items.Clear();
                }

                DataContext context = new DataContext(connectionString);

                context.ExecuteCommand("TRUNCATE TABLE RushDataBasesServersList.Raports.Info");
                context.ExecuteCommand("DBCC CHECKIDENT('Raports.Info', RESEED, 1)");

                context.ExecuteCommand("TRUNCATE TABLE RushDataBasesServersList.Raports.Errors");
                context.ExecuteCommand("DBCC CHECKIDENT('Raports.Errors', RESEED, 1)");

                context.ExecuteCommand("TRUNCATE TABLE RushDataBasesServersList.Raports.Compleate");
                context.ExecuteCommand("DBCC CHECKIDENT('Raports.Compleate', RESEED, 1)");

            });
        }
        #endregion ClearRaports

        #region Dispatcher
        public static async Task Dispatcher(string connectionString, IEnumerable<string> serversList, IEnumerable<string> scriptsList, int threads)
        {
            await Task.Run(async () =>
            {
                try
                {
                    if (string.IsNullOrEmpty(connectionString)) throw new Exception("Connection string is empty");
                    if (serversList.Count() < 1) throw new Exception("Ни один из серверов не выбран.");
                    if (scriptsList.Count() < 1) throw new Exception("Ни один из скриптов не выбран.");

                    Dictionary<string, string> scriptsContent = await GetScripts(connectionString, scriptsList);
                    List<nestedServer> servers = await GetServers(connectionString, serversList);
                    List<nestedPackage> packages = await GetPackages(servers, scriptsContent);

                    Parallel.ForEach(packages, new ParallelOptions { MaxDegreeOfParallelism = threads }, package =>
                    {
                        Task.Run(async () =>
                        {
                            await Parse(package, connectionString);
                        });
                    });


                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            });
        }
        #endregion Dispatcher

        #region Parse
        private static async Task Parse(nestedPackage package, string connectionString)
        {
            await Task.Run(() =>
            {
                string serverConnectionString = $"Server={package.Server.ServerDomainName};Database={package.Server.DataBaseName};User={package.Server.ServerLogin};Password={package.Server.ServerPassword};";

                using (SqlConnection connection = new SqlConnection(serverConnectionString))
                {
                    string[] partsList = null;

                    DataContext pathContext = new DataContext(connection);

                    DataContext raportContext = new DataContext(connectionString);

                    string script = "";

                    connection.InfoMessage += (object sender, SqlInfoMessageEventArgs e) =>
                    {
                        raportContext.ExecuteCommand($"INSERT INTO Raports.Info (DataTime, ServerDB, Script, MessageInfo) VALUES (DEFAULT, 'Server:{package.Server.ServerDomainName} DB:{package.Server.DataBaseName}', '{script}', N'{e.Message}')");
                    };

                    bool hasError;

                    foreach (var i in package.Scripts)
                    {
                        script = i.Key;

                        partsList = i.Value.Split(new string[] { "go;", "GO;", "go", "GO" }, StringSplitOptions.RemoveEmptyEntries);
                        hasError = false;

                        foreach (var j in partsList)
                        {
                            try
                            {
                                pathContext.ExecuteCommand(j);
                            }
                            catch (System.Data.SqlClient.SqlException ex)
                            {
                                hasError = true;

                                raportContext.ExecuteCommand($"INSERT INTO Raports.Errors (DataTime, ServerDBUserPasswd, ScriptName, ErrorCode, ErrorMessage) VALUES (DEFAULT, 'Server:{package.Server.ServerDomainName} DB:{package.Server.DataBaseName}', '{i.Key}', {ex.Number}, N'System.Data.SqlClient.SqlException: {ex.Message}')");
                            }

                            catch (Microsoft.Data.SqlClient.SqlException ex)
                            {
                                hasError = true;

                                raportContext.ExecuteCommand($"INSERT INTO Raports.Errors (DataTime, ServerDBUserPasswd, ScriptName, ErrorCode, ErrorMessage) VALUES (DEFAULT, 'Server:{package.Server.ServerDomainName} DB:{package.Server.DataBaseName}', '{i.Key}', {ex.Number}, N'Microsoft.Data.SqlClient.SqlException: {ex.Message}')");
                            }



                        }
                        if (hasError == false)
                        {
                            raportContext.ExecuteCommand($"INSERT INTO Raports.Compleate (DataTime, ServerDBUserPasswd, ScriptName) VALUES (DEFAULT, 'Server:{package.Server.ServerDomainName} DB:{package.Server.DataBaseName}', '{i.Key}')");
                        }
                    }
                }
            });

        }
        #endregion Parse

        #region GetPackages
        private static async Task<List<nestedPackage>> GetPackages(List<nestedServer> servers, Dictionary<string, string> scriptsContent)
        {
            return await Task<List<nestedPackage>>.Run(() =>
            {
                List<nestedPackage> paskagesRet = new List<nestedPackage>();

                foreach (var i in servers)
                {
                    paskagesRet.Add(new nestedPackage() { Server = i, Scripts = scriptsContent });
                }

                return paskagesRet;
            });
        }
        #endregion GetPackages

        #region GetScripts
        private static async Task<Dictionary<string, string>> GetScripts(string connectionString, IEnumerable<string> scriptsList)
        {
            return await Task<Dictionary<string, string>>.Run(() =>
            {
                Dictionary<string, string> scriptsContentDictionary = new Dictionary<string, string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataContext dataContext = new DataContext(connection);

                    string query = "SELECT st.ScriptName, st.ScriptContent FROM Scripts.ScriptsTable st WHERE st.ScriptName IN (";

                    for (int i = 0; i < scriptsList.Count(); i++)
                    {
                        if (i == 0)
                        {
                            query += $"'{scriptsList.ElementAt(i)}'";
                        }
                        else
                        {
                            query += $",'{scriptsList.ElementAt(i)}'";
                        }
                    }
                    query += ")";

                    var scriptsContemtList = dataContext.ExecuteQuery<nestedScriptsContent>(query);

                    foreach (var i in scriptsContemtList)
                    {
                        scriptsContentDictionary.Add(i.ScriptName, i.ScriptContent);
                    }

                }
                return scriptsContentDictionary;
            });
        }
        #endregion GetScripts

        #region GetServers
        private static async Task<List<nestedServer>> GetServers(string connectionString, IEnumerable<string> serversList)
        {
            return await Task<List<nestedServer>>.Run(() =>
            {
                List<string> domainNames = new List<string>();
                List<string> DBNames = new List<string>();

                List<nestedServer> serversRet = new List<nestedServer>();

                string query = "";
                nestedServer row;

                foreach (var i in serversList.Select(s => s.Split('#')))
                {
                    domainNames.Add(i[0]);
                    DBNames.Add(i[1]);
                }



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataContext context = new DataContext(connection);

                    for (int i = 0; i < serversList.Count(); i++)
                    {
                        query = $"SELECT sl.ServerDomainName,sl.DataBaseName,sl.ServerLogin,sl.ServerPassword FROM RushDataBasesServersList.ServersAndMarkers.ServerList sl WHERE sl.ServerDomainName='{domainNames[i]}' AND sl.DataBaseName='{DBNames[i]}'";

                        row = context.ExecuteQuery<nestedServer>(query).FirstOrDefault();

                        if ((row is null) == false)
                        {
                            serversRet.Add(row);
                        }
                    }
                }

                return serversRet;
            });
        }
        #endregion GetServers
    }

}
