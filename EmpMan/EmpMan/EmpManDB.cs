/*
* EmpMan Database Class
* Authors: Nick Filauro & Erika Gepilano
* April 2016 * Version 1
*
* Updated 11/18/2016 * Version 2 * Elliot Stoner
* Updated 06/17/2017 * Version 3 * Frank Friedman
*
* Purpose: A class that interacts and performs database operations for Empman
* in a Microsoft Access database using an OLEDB Data Reader.
* It will contain methods for CRUD (Create, Read, Update, Delete) operations.
*
* !! Requirements !!
* You must have the Access Database Engine installed on the system you are running the
program on.
* https://www.microsoft.com/en-us/download/details.aspx?id=13255
*
* No constructors were written
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
namespace EmpMan
{
    class EmpManDB
    {
        // Connection string for EmpManDB (type: Microsoft Access) in the Resources folder
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + "DataSource =../Debug/Resources/EmpManDB.accdb";
        // *********** INSERTION METHODS **********
        // Inserts a new record for Person in the Person table with parameters name, birthDate and personID
        public bool InsertPerson(int personID, string personName, string personBirthDate)
        {
            // SQL insert statement for Person
            string strInsertPerson = "INSERT INTO PERSON(fldID, fldName, fldBirthDate) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + "');";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertPerson, myConnection);
            OleDbDataReader myDataReader;
            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)

            {
                Console.Write("There was an Insert Person error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        } // end InsertPerson

        public bool InsertClient(int personID, string personName, string personBirthDate,string clientType)
        {
            // SQL insert statement for Client
            string strInsertClient = "INSERT INTO CLIENT(fldID, fldName, fldBirthDate, fldType) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + clientType + "');";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertClient, myConnection);
            OleDbDataReader myDataReader;
            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)

            {
                Console.Write("There was an Insert Client error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        } // end InsertClient

        public bool InsertEmployee(int personID, string personName, string personBirthDate,string employeeJobTitle)
        {
            // SQL insert statement for Employee
            string strInsertEmployee = "INSERT INTO EMPLOYEE(fldID, fldName, fldBirthDate, fldTitle) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + employeeJobTitle + "');";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertEmployee, myConnection);
            OleDbDataReader myDataReader;
            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)

            {
                Console.Write("There was an Insert Employee error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        } // end InsertEmployee

        public bool InsertWorker(int personID, string personName, string personBirthDate, decimal workerPay, string employeeJobTitle)
        {
            // SQL insert statement for Worker
            string strInsertWorker = "INSERT INTO WORKER(fldID, fldName, fldBirthDate, fldType, fldPay) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + employeeJobTitle + workerPay + "');";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertWorker, myConnection);
            OleDbDataReader myDataReader;
            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)

            {
                Console.Write("There was an Insert Worker error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        } // end InsertWorker

        public bool InsertManager(int personID, string personName, string personBirthDate, decimal managerBonus, decimal managerSalary, string employeeJobTitle)
        {
            // SQL insert statement for Person
            string strInsertManager = "INSERT INTO MANAGER(fldID, fldName, fldBirthDate, fldType, fldSalary, fldBonus) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + employeeJobTitle + managerBonus + managerSalary + "');";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertManager, myConnection);
            OleDbDataReader myDataReader;
            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)

            {
                Console.Write("There was an Insert Manager error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        } // end InsertManager


        public OleDbDataReader SelectPersonFromWorker(int personID, out bool OKFlag)
        {
            string strSelectPerson = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, "
                + "Employee.fldTitle, Worker.fldHourlyPay FROM (PERSON "
                + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID) "
                + "INNER JOIN WORKER ON WORKER.fldID = PERSON.fldID "
                + "WHERE Person.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectPerson, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an error: " + ex.Message);
                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        } // end SelectPersonFromWorker

        public OleDbDataReader SelectPersonFromClient(int personID, out bool OKFlag)
        {
            // string strSelectPerson = "SELECT * FROM CLIENT WHERE CLIENT.fldID = " + personID; 
            string strSelectPerson = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, "
               + "CLIENT.fldType FROM PERSON "
               + "INNER JOIN CLIENT ON CLIENT.fldID = PERSON.fldID "
               + "WHERE CLIENT.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectPerson, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an error: " + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }  // end SelectPersonFromClient

        internal OleDbDataReader SelectPersonFromManager(int personID, out bool OKFlag)
        {
            // string strSelectPerson = "SELECT * FROM MANAGER WHERE MANAGER.fldID = " + personID; 
            string strSelectPerson = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, "
                 + "Employee.fldTitle, Manager.fldSalary, Manager.fldBonus FROM (PERSON "
                 + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID) "
                 + "INNER JOIN MANAGER ON MANAGER.fldID = PERSON.fldID "
                 + "WHERE Person.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectPerson, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an error: " + ex.Message);
                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }

        public OleDbDataReader SelectPersonFromEmployee(int personID, out bool OKFlag)
        {
            // string strSelectPerson = "SELECT * FROM EMPLOYEE WHERE EMPLOYEE.fldID = " + personID; 
            string strSelectPerson = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, "
               + "EMPLOYEE.fldType FROM PERSON "
               + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID "
               + "WHERE EMPLOYEE.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectPerson, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an error: " + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }

        public bool UpdateClient(int clientID, string clientType)
        {
            string strUpdateClient = "UPDATE Client SET fldType = '" + clientType + "' WHERE fldId = " + clientID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateClient, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Client error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Client

        public bool UpdateEmployee(int employeeID, string employeeJobTitle)
        {
            string strUpdateEmployee = "UPDATE Employee SET fldTitle = '" + employeeJobTitle + "' WHERE fldId = " + employeeID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateEmployee, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Employee error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }

        public bool UpdateWorker(int workerID, decimal workerPay)
        {
            string strUpdateWorker = "UPDATE Worker SET fldPay = '" + workerPay + "' WHERE fldId = " + workerID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateWorker, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Worker error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }

        public bool UpdateManager(int managerID, decimal managerSalary, decimal managerBonus)
        {
            string strUpdateManager = "UPDATE Manager SET fldSalary = '" + managerSalary + "UPDATE Manager SET fldBonus = '" + managerBonus + "' WHERE fldId = " + managerID;

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateManager, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Manager error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }

        // ********** DELETE Method ********** 
        // Deletes records from Person, Client, Employee, Manager, and Worker tables that match integer parameter personID
        // Uses strConnection to open a connection with the database
        // Deletes Person with given ID from every table in the database
        // If a person with the given ID is not in a table, the Delete command does nothing
        // Code written by Christopher Tither and Frank Branigan, CIS 3309 Section 1, April 2017
        public void Delete(int personID)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("DELETE FROM Person WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                    }
                    using (OleDbCommand command2 = new OleDbCommand("DELETE FROM Client WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                    }
                    using (OleDbCommand command3 = new OleDbCommand("DELETE FROM Employee WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                    }
                    using (OleDbCommand command4 = new OleDbCommand("DELETE FROM Manager WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                    }
                    using (OleDbCommand command5 = new OleDbCommand("DELETE FROM Worker WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
            // FormController.clear(this);
        }  // end Delete


    }
}
