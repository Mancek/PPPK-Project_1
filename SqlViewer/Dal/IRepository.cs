using SqlViewer.Models;
using System.Collections.Generic;

namespace SqlViewer.Dal
{
    interface IRepository
    {
        OutputResult ExecuteCommand(string tbQuery, Database usingDatabase);
        IEnumerable<Database> GetDatabases();
        void LogIn(string server, string username, string password);
    }
}