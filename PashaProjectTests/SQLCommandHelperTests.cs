using Microsoft.VisualStudio.TestTools.UnitTesting;
using MenegmentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MenegmentSystem.Tests
{
    [TestClass()]
    public class SQLCommandHelperTests
    {
        private SqlConnection connection;

        [TestMethod()]
        public void SqlChange_InsertingData_Success()
        {
            // Arrange
            string query = "INSERT INTO UserData VALUES ('Hello', 'World')";
            string message = "";

            // Act
            var obj = new SQLCommandHelper(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
            obj.sqlChange(query,message);

            //Assert
            Assert.IsTrue(obj.GetConnectionState());
        }

        [TestMethod()]
        public void SqlChange_UpdatingData_Success()
        {
            // Arrange
            string query = "UPDATE UserData SET username = 'NewValue'";
            string message = "";

            // Act
            var obj = new SQLCommandHelper(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
            obj.sqlChange(query, message);

            //Assert
            Assert.IsTrue(obj.GetConnectionState());
        }

        [TestMethod()]
        public void SqlChange_DeletingData_Success()
        {
            // Arrange
            string query = "DELETE FROM UserData WHERE username = 'Hello'";
            string message = "";

            // Act
            var obj = new SQLCommandHelper(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
            obj.sqlChange(query, message);

            //Assert
            Assert.IsTrue(obj.GetConnectionState());
        }
    }
}