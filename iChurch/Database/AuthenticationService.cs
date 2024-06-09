using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSystem.Database
{
    internal class AuthenticationService
    {
        private readonly DatabaseConnection _dbConnection;

        public AuthenticationService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckCredentials(string username, string password)
        {
            return _dbConnection.CheckCredentials(username, password);
        }
    }
}
