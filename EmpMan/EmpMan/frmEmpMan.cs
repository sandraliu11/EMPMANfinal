using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EmpMan
{
    public partial class frmEmpMan : Form
    {
        public frmEmpMan()
        {
            InitializeComponent();
        }
        private string searchedPersonType;
        private string addedPerson;
        private PersonList personList = new PersonList();
        private Validators validator = new Validators();
        private EmpManDB dbFunctions = new EmpManDB();
        private string fileName = "file1.bin";
        private int recordsProcessedCount = 0;

        //Control Event Methods
        //
        private void frmEmpMan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //write file
            //POManager.WriteToFile(ref personList, fileName);
            MessageBox.Show(personList.printList());
           // displayDbInformation();
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            //read file
            POManager.ReadFromFile(out personList, fileName);
            toggleLoadView(true);
        }
        //
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            toggleLoadView(false);
            toggleAddSelectPersonTypeView(true);
            toggleAllReadOnly(false);
            resetTextboxes();
        }
        //
        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            toggleAddSelectPersonTypeView(false);
            toggleAddClientView(true);
            //addedPerson = "client";
        }
        //
        private void btnCreateWorker_Click(object sender, EventArgs e)
        {
            toggleAddSelectPersonTypeView(false);
            toggleAddWorkerView(true);
            //addedPerson = "worker";
        }
        //
        private void btnCreateManager_Click(object sender, EventArgs e)
        {
            toggleAddSelectPersonTypeView(false);
            toggleAddManagerView(true);
            //addedPerson = "manager";
        }
        //
        private void pcbBackFromAddSelectPersonType_Click(object sender, EventArgs e)
        {
            toggleAddSelectPersonTypeView(false);
            toggleLoadView(true);
            clearForms();
        }
        //
        private void pcbBackFromAddDetailView_Click(object sender, EventArgs e)
        {
            toggleAddWorkerView(false);
            toggleAddManagerView(false);
            toggleAddClientView(false);
            toggleAddSelectPersonTypeView(true);
            clearForms();
        }
        //
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            toggleLoadView(false);
            toggleSearchView(true);
        }
        //
        private void pcbBackFromSearch_Click(object sender, EventArgs e)
        {
            toggleLoadView(true);
            toggleSearchView(false);
            clearForms();
        }
        //
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person p = personList.search(txtSearch.Text);
            if (p != null)
            {
                toggleEditButtons(true);
                toggleSearchView(false);
                if (p.GetType() == typeof(Client))
                {
                    searchedPersonType = "client";
                    toggleEditClientView(true);
                    toggleEditClientReadOnly(true);
                    txtPersonName.Text = p.personName;
                    txtPersonID.Text = p.personID;
                    txtPersonDOB.Text = Convert.ToString(p.personBirthDate).Substring(0, 10);
                    txtClientType.Text = ((Client)p).clientType;
                    // Search for client from DB
                    dbFunctions.SelectPersonFromClient(Convert.ToInt32(txtPersonID.Text), out bool success);
                }
                if (p.GetType() == typeof(Worker))
                {
                    searchedPersonType = "worker";
                    toggleEditWorkerView(true);
                    toggleEditWorkerReadOnly(true);
                    txtPersonName.Text = p.personName;
                    txtPersonID.Text = p.personID;
                    txtPersonDOB.Text = Convert.ToString(p.personBirthDate).Substring(0, 10);
                    txtWorkerPay.Text = Convert.ToString(((Worker)p).workerPay);
                    txtWorkerTitle.Text = ((Employee)p).employeeJobTitle;
                    // Search for worker from DB
                    dbFunctions.SelectPersonFromWorker(Convert.ToInt32(txtPersonID.Text), out bool success);
                }
                if (p.GetType() == typeof(Manager))
                {
                    searchedPersonType = "manager";
                    toggleEditManagerView(true);
                    toggleEditManagerReadOnly(true);
                    txtPersonName.Text = p.personName;
                    txtPersonID.Text = p.personID;
                    txtPersonDOB.Text = Convert.ToString(p.personBirthDate).Substring(0, 10);
                    txtManagerBonus.Text = Convert.ToString(((Manager)p).managerBonus);
                    txtManagerSalary.Text = Convert.ToString(((Manager)p).managerSalary);
                    txtManagerTitle.Text = ((Employee)p).employeeJobTitle;
                    // Search for manager from DB
                    dbFunctions.SelectPersonFromManager(Convert.ToInt32(txtPersonID.Text), out bool success);
                }
            }
            if (p == null)
            {
                MessageBox.Show("ID not found");
            }
        }
        //
        private void pcbBackFromEdit_Click(object sender, EventArgs e)
        {
            toggleEditButtons(true);
            toggleEditSearch(false);
            if (searchedPersonType == "manager")
            {
                toggleEditManagerReadOnly(true);
            }
            if (searchedPersonType == "worker")
            {
                toggleEditWorkerReadOnly(true);
            }
            if (searchedPersonType == "client")
            {
                toggleEditClientReadOnly(true);
            }
            clearForms();
        }
        //
        private void pcbBackFromSearchResults_Click(object sender, EventArgs e)
        {
            toggleEditButtons(false);
            toggleEditManagerView(false);
            toggleEditWorkerView(false);
            toggleEditClientView(false);
            toggleSearchView(true);
            clearForms();
        }
        //
        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (searchedPersonType == "manager")
            {

                if ((validator.validateString(txtPersonName.Text) == true)
                && (validator.validateDate(txtPersonDOB.Text) == true) && (validator.validateString(txtManagerTitle.Text) == true)
                && (validator.validateCurrency(txtManagerSalary.Text) == true) && (validator.validateCurrency(txtManagerBonus.Text) == true))
                {
                    decimal managerBonus = Convert.ToDecimal(txtManagerBonus.Text);
                    decimal managerSalary = Convert.ToDecimal(txtManagerSalary.Text);
                    int managerID = Convert.ToInt32(txtPersonID.Text);

                    // Add manager to person list and save
                    personList.searchAndDelete(txtSearch.Text);
                    MessageBox.Show("Manager added to list and saved!");
                    Manager newManager = new Manager(txtPersonName.Text, txtPersonDOB.Text, txtPersonID.Text, txtManagerTitle.Text, Convert.ToDecimal(txtManagerSalary.Text), Convert.ToDecimal(txtManagerBonus.Text));
                    personList.add(newManager);
                    // Update manager in DB
                    dbFunctions.UpdateManager(managerID, managerSalary, managerBonus);
                    //displayDbInformation(newManager);
                    toggleAddManagerView(false);
                    toggleLoadView(true);
                    resetTextboxes();
                    toggleEditSearch(false);
                    toggleEditManagerView(false);
                    toggleEditManagerReadOnly(true);
                }
                else if (validator.validatePersonID(txtPersonID.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank manager ID with only numbers.");
                    txtPersonID.Focus();
                }
                else if (validator.validateString(txtPersonName.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank manager name with only letters.");
                    txtPersonName.Focus();
                }
                else if (validator.validateDate(txtPersonDOB.Text) == false)
                {
                    MessageBox.Show("Please enter a valid non-blank manager birthdate in MM/DD/YYYY format with numbers only.");
                    txtPersonDOB.Focus();
                }
                else if (validator.validateString(txtManagerTitle.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank manager title with only letters.");
                    txtWorkerTitle.Focus();
                }
                else if (validator.validateCurrency(txtManagerSalary.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank manager salary in 00.00 format.");
                    txtManagerSalary.Focus();
                }
                else if (validator.validateCurrency(txtManagerBonus.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank manager bonus in 00.00 format.");
                    txtManagerBonus.Focus();
                }
            }
            if (searchedPersonType == "worker")
            {


                if ((validator.validateString(txtPersonName.Text) == true)
                && (validator.validateDate(txtPersonDOB.Text) == true) && (validator.validateString(txtWorkerTitle.Text) == true)
                && (validator.validateCurrency(txtWorkerPay.Text) == true))
                {
                    decimal workerPay = Convert.ToInt32(txtWorkerPay.Text);
                    // Add worker to person list and save
                    personList.searchAndDelete(txtSearch.Text);
                    MessageBox.Show("Worker added to list and saved!");
                    Worker newWorker = new Worker(txtPersonName.Text, txtPersonDOB.Text, txtPersonID.Text, txtWorkerTitle.Text, Convert.ToDecimal(txtWorkerPay.Text));
                    personList.add(newWorker);
                    // Update manager in DB
                    dbFunctions.UpdateWorker(Convert.ToInt32(txtPersonID.Text), workerPay);
                    //displayDbInformation(newWorker);
                    toggleAddWorkerView(false);
                    toggleLoadView(true);
                    resetTextboxes();
                    toggleEditSearch(true);
                    toggleEditWorkerView(false);
                    toggleEditWorkerReadOnly(true);
                }
                else if (validator.validatePersonID(txtPersonID.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank person ID with only numbers.");
                    txtPersonID.Focus();
                }
                else if (validator.validateString(txtPersonName.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank client name with only letters.");
                    txtPersonName.Focus();
                }
                else if (validator.validateDate(txtPersonDOB.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank person birthdate in MM/DD/YYYY format with numbers only.");
                    txtPersonDOB.Focus();
                }
                else if (validator.validateString(txtWorkerTitle.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank worker title with only letters.");
                    txtWorkerTitle.Focus();
                }
                else if (validator.validateCurrency(txtWorkerPay.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank worker pay in 00.00 format.");
                    txtWorkerPay.Focus();
                }
            }
            if (searchedPersonType == "client")
            {
                if ((validator.validateString(txtClientType.Text) == true) && (validator.validateString(txtPersonName.Text) == true)
                && (validator.validateDate(txtPersonDOB.Text) == true))
                {
                    // Add client to person list and save
                    personList.searchAndDelete(txtSearch.Text);
                    MessageBox.Show("Client added to list and saved!");
                    Client newClient = new Client(txtPersonName.Text, txtPersonDOB.Text, txtPersonID.Text, txtClientType.Text);
                    personList.add(newClient);
                    // Update manager in DB
                    dbFunctions.UpdateClient(Convert.ToInt32(txtPersonID.Text), txtClientType.Text);
                    //displayDbInformation(newClient);
                    toggleAddClientView(false);
                    toggleLoadView(true);
                    resetTextboxes();
                    toggleEditSearch(false);
                    toggleEditClientView(false);
                    toggleEditClientReadOnly(true);
                }
                else if (validator.validatePersonID(txtPersonID.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank person ID with only numbers.");
                    txtPersonID.Focus();
                }
                else if (validator.validateString(txtPersonName.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank client name with only letters.");
                    txtPersonName.Focus();
                }
                else if (validator.validateDate(txtPersonDOB.Text) == false)
                {
                    MessageBox.Show("Please enter a valid non-blank person birthdate in MM/DD/YYYY format with numbers only.");
                    txtPersonDOB.Focus();
                }
                else if (validator.validateString(txtClientType.Text) == false)
                {
                    MessageBox.Show("Please enter a non-blank client type with only letters.");
                    txtClientType.Focus();
                }
            }
        }
        //
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this person?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                toggleEditButtons(false);
                toggleEditClientView(false);
                toggleEditManagerView(false);
                toggleEditWorkerView(false);
                toggleLoadView(true);
                //delete person
                personList.searchAndDelete(txtSearch.Text);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
        //
        private void btnEdit_Click(object sender, EventArgs e)
        {
            toggleEditButtons(false);
            toggleEditSearch(true);
            if (searchedPersonType == "manager")
            {
                toggleEditManagerReadOnly(false);
            }
            if (searchedPersonType == "worker")
            {
                toggleEditWorkerReadOnly(false);
            }
            if (searchedPersonType == "client")
            {
                toggleEditClientReadOnly(false);
            }
        }
        //
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            bool unique = true;
            //some search to check id
            Person checkID = personList.search(txtPersonID.Text);
            this.AcceptButton = btnAddSave;
            if (checkID == null)
            {
                //MessageBox.Show("Record Saved or something...");
                //Add manager record with validation for all user-entered attributes
                if (addedPerson == "manager")
                {
                    if ((validator.validatePersonID(txtPersonID.Text) == true) && (validator.validateString(txtPersonName.Text) == true)
                && (validator.validateDate(txtPersonDOB.Text) == true) && (validator.validateString(txtManagerTitle.Text) == true)
                && (validator.validateCurrency(txtManagerSalary.Text) == true) && (validator.validateCurrency(txtManagerBonus.Text) == true))
                    {
                        // Add manager to person list and save
                        MessageBox.Show("Manager added to list and saved!");
                        Manager newManager = new Manager(txtPersonName.Text, txtPersonDOB.Text, txtPersonID.Text, txtManagerTitle.Text, Convert.ToDecimal(txtManagerSalary.Text), Convert.ToDecimal(txtManagerBonus.Text));
                        personList.add(newManager);
                        // Add manager into DB
                        dbFunctions.InsertPerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonDOB.Text);
                        dbFunctions.InsertManager(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonDOB.Text, Convert.ToDecimal(txtManagerBonus.Text), Convert.ToDecimal(txtManagerSalary.Text), txtManagerTitle.Text);
                        //displayDbInformation(newManager);
                        toggleAddManagerView(false);
                        toggleLoadView(true);
                        resetTextboxes();
                    }
                    else if (validator.validatePersonID(txtPersonID.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank manager ID with only numbers.");
                        txtPersonID.Focus();
                    }
                    else if (validator.validateString(txtPersonName.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank manager name with only letters.");
                        txtPersonName.Focus();
                    }
                    else if (validator.validateDate(txtPersonDOB.Text) == false)
                    {
                        MessageBox.Show("Please enter a valid non-blank manager birthdate in MM/DD/YYYY format with numbers only.");
                        txtPersonDOB.Focus();
                    }
                    else if (validator.validateString(txtManagerTitle.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank manager title with only letters.");
                        txtWorkerTitle.Focus();
                    }
                    else if (validator.validateCurrency(txtManagerSalary.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank manager salary in 00.00 format.");
                        txtManagerSalary.Focus();
                    }
                    else if (validator.validateCurrency(txtManagerBonus.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank manager bonus in 00.00 format.");
                        txtManagerBonus.Focus();
                    }

                }
                //Add client record with validation for all user-entered attributes
                if (addedPerson == "client")
                {
                    if ((validator.validateString(txtClientType.Text) == true) && (validator.validateString(txtPersonName.Text) == true)
                && (validator.validatePersonID(txtPersonID.Text) == true) && (validator.validateDate(txtPersonDOB.Text) == true))
                    {
                        // Add client to person list and save
                        MessageBox.Show("Client added to list and saved!");
                        Client newClient = new Client(txtPersonName.Text, txtPersonDOB.Text, txtPersonID.Text, txtClientType.Text);
                        personList.add(newClient);
                        // Add client into DB
                        dbFunctions.InsertPerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonDOB.Text);
                        dbFunctions.InsertClient(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonDOB.Text, txtClientType.Text);
                        //displayDbInformation(newClient);
                        toggleAddClientView(false);
                        toggleLoadView(true);
                        resetTextboxes();
                    }
                    else if (validator.validatePersonID(txtPersonID.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank person ID with only numbers.");
                        txtPersonID.Focus();
                    }
                    else if (validator.validateString(txtPersonName.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank client name with only letters.");
                        txtPersonName.Focus();
                    }
                    else if (validator.validateDate(txtPersonDOB.Text) == false)
                    {
                        MessageBox.Show("Please enter a valid non-blank person birthdate in MM/DD/YYYY format with numbers only.");
                        txtPersonDOB.Focus();
                    }
                    else if (validator.validateString(txtClientType.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank client type with only letters.");
                        txtClientType.Focus();
                    }
                }
                //Add worker record with validation for all user-entered attributes
                if (addedPerson == "worker")
                {
                    if ((validator.validatePersonID(txtPersonID.Text) == true) && (validator.validateString(txtPersonName.Text) == true)
                && (validator.validateDate(txtPersonDOB.Text) == true) && (validator.validateString(txtWorkerTitle.Text) == true)
                && (validator.validateCurrency(txtWorkerPay.Text) == true))
                    {
                        // Add manager to person list and save
                        MessageBox.Show("Worker added to list and saved!");
                        Worker newWorker = new Worker(txtPersonName.Text, txtPersonDOB.Text, txtPersonID.Text, txtWorkerTitle.Text, Convert.ToDecimal(txtWorkerPay.Text));
                        personList.add(newWorker);
                        // Add worker into DB
                        dbFunctions.InsertPerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonDOB.Text);
                        dbFunctions.InsertWorker(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonDOB.Text, Convert.ToDecimal(txtWorkerPay.Text), txtWorkerTitle.Text);
                        //displayDbInformation(newWorker);
                        toggleAddWorkerView(false);
                        toggleLoadView(true);
                        resetTextboxes();
                    }
                    else if (validator.validatePersonID(txtPersonID.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank person ID with only numbers.");
                        txtPersonID.Focus();
                    }
                    else if (validator.validateString(txtPersonName.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank client name with only letters.");
                        txtPersonName.Focus();
                    }
                    else if (validator.validateDate(txtPersonDOB.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank person birthdate in MM/DD/YYYY format with numbers only.");
                        txtPersonDOB.Focus();
                    }
                    else if (validator.validateString(txtWorkerTitle.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank worker title with only letters.");
                        txtWorkerTitle.Focus();
                    }
                    else if (validator.validateCurrency(txtWorkerPay.Text) == false)
                    {
                        MessageBox.Show("Please enter a non-blank worker pay in 00.00 format.");
                        txtWorkerPay.Focus();
                    }
                }
                //toggleLoadView(true);
            }
            else
            {
                MessageBox.Show("ID is already used. Select a new ID");
            }

        }
        //
        private void clearForms()
        {
            txtClientType.Text = "";
            txtManagerBonus.Text = "";
            txtManagerSalary.Text = "";
            txtManagerTitle.Text = "";
            txtPersonDOB.Text = "";
            txtPersonID.Text = "";
            txtPersonName.Text = "";
            txtSearch.Text = "";
            txtWorkerPay.Text = "";
            txtWorkerTitle.Text = "";
        }

        //Control Toggles
        //toggles the start controls
        private void toggleLoadView(bool toggle)
        {
            btnAddPerson.Visible = toggle;
            btnSearchPerson.Visible = toggle;
        }
        //
        private void toggleAllReadOnly(bool toggle)
        {
            txtPersonID.ReadOnly = toggle;
            txtPersonName.ReadOnly = toggle;
            txtPersonDOB.ReadOnly = toggle;
            txtClientType.ReadOnly = toggle;
            txtManagerBonus.ReadOnly = toggle;
            txtManagerSalary.ReadOnly = toggle;
            txtManagerTitle.ReadOnly = toggle;
            txtWorkerPay.ReadOnly = toggle;
            txtWorkerTitle.ReadOnly = toggle;
        }
        //toggles the person selection buttons
        private void toggleAddSelectPersonTypeView(bool toggle)
        {
            pcbBackFromAddSelectPersonType.Visible = toggle;
            btnCreateClient.Visible = toggle;
            btnCreateManager.Visible = toggle;
            btnCreateWorker.Visible = toggle;
        }
        //toggles the panels and other controls when added a client
        private void toggleAddClientView(bool toggle)
        {
            addedPerson = "client";
            pcbBackFromAddDetailView.Visible = toggle;
            pnlPersonForm.Visible = toggle;
            pnlClientForm.Visible = toggle;
            btnAddSave.Visible = toggle;
        }
        //toggles the panels and other controls when added a worker
        private void toggleAddWorkerView(bool toggle)
        {
            addedPerson = "worker";
            pcbBackFromAddDetailView.Visible = toggle;
            pnlPersonForm.Visible = toggle;
            pnlWorkerPanel.Visible = toggle;
            btnAddSave.Visible = toggle;
        }
        //toggles the panels and other controls when added a manager
        private void toggleAddManagerView(bool toggle)
        {
            addedPerson = "manager";
            pcbBackFromAddDetailView.Visible = toggle;
            pnlPersonForm.Visible = toggle;
            pnlManagerForm.Visible = toggle;
            btnAddSave.Visible = toggle;
        }
        //toggles the search panel
        private void toggleSearchView(bool toggle)
        {
            pnlSearch.Visible = toggle;
            pcbBackFromSearch.Visible = toggle;
        }
        //toggles the panels and other controls when editting a manager
        private void toggleEditManagerView(bool toggle)
        {
            pnlPersonForm.Visible = toggle;
            pnlManagerForm.Visible = toggle;
        }
        //toggles the panels and other controls when editting a worker
        private void toggleEditWorkerView(bool toggle)
        {
            pnlPersonForm.Visible = toggle;
            pnlWorkerPanel.Visible = toggle;
        }
        //toggles the panels and other controls when editting a client
        private void toggleEditClientView(bool toggle)
        {
            pnlPersonForm.Visible = toggle;
            pnlClientForm.Visible = toggle;

        }
        //toggles the buttons for editing
        private void toggleEditButtons(bool toggle)
        {
            pcbBackFromSearchResults.Visible = toggle;
            btnEdit.Visible = toggle;
            btnDelete.Visible = toggle;
        }
        //toggles the managers textbox readonly attributes
        private void toggleEditManagerReadOnly(bool toggle)
        {
            toggleEditPersonReadOnly(toggle);
            txtManagerBonus.ReadOnly = toggle;
            txtManagerSalary.ReadOnly = toggle;
            txtManagerTitle.ReadOnly = toggle;
        }
        //toggles the worker textbox readonly attributes
        private void toggleEditWorkerReadOnly(bool toggle)
        {
            toggleEditPersonReadOnly(toggle);
            txtWorkerPay.ReadOnly = toggle;
            txtWorkerTitle.ReadOnly = toggle;
        }
        //toggles the client textbox readonly attributes
        private void toggleEditClientReadOnly(bool toggle)
        {
            toggleEditPersonReadOnly(toggle);
            txtClientType.ReadOnly = toggle;
        }
        //toggles the person textbox readonly attributes
        private void toggleEditPersonReadOnly(bool toggle)
        {
            txtPersonDOB.ReadOnly = toggle;
            txtPersonID.ReadOnly = true;
            txtPersonName.ReadOnly = toggle;
        }
        //toggles search result buttons
        private void toggleEditSearch(bool toggle)
        {
            btnEditSave.Visible = toggle;
            pcbBackFromEdit.Visible = toggle;
        }
        //resets all data entry textboxes to blank for reuse in form
        private void resetTextboxes()
        {
            txtPersonID.Text = "";
            txtPersonName.Text = "";
            txtSearch.Text = "";
            txtWorkerPay.Text = "";
            txtWorkerTitle.Text = "";
            txtClientType.Text = "";
            txtManagerBonus.Text = "";
            txtManagerSalary.Text = "";
            txtManagerTitle.Text = "";
            txtPersonDOB.Text = "";
        }

        /*void displayDbInformation(Person p)
        {
            bool successFlag;
            if (p == null)
            {
                MessageBox.Show("Person p reference is null. System Error. Program Terminated.",
                    "displayDbInformation Reference Error", MessageBoxButtons.OK);
                this.Close();
            }  // end p == null if

            OleDbDataReader myDataReader;
            string dbStringPerson = " ";
            string dbStringRest = " ";

            if (p.GetType() == typeof(Client))     // Process CLIENT
            {
                myDataReader = dbFunctions.SelectPersonFromClient(Convert.ToInt32(txtPersonID.Text), out successFlag);
                myDataReader.Read();
                if (!myDataReader.HasRows)
                {
                    MessageBox.Show("DataReader returned null. No match found. DB and Serializable File not synched.  Program Terminated",
                        "Client SELECT Error", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Client record found and read.  ", "Client Record Found", MessageBoxButtons.OK);
                    try
                    {
                        dbStringPerson = myDataReader[0].ToString() + "   " + myDataReader[1].ToString() + "   ";
                        dbStringPerson = dbStringPerson + ((DateTime)myDataReader[2]).ToString("MM/dd/yyyy") + Environment.NewLine;
                        dbStringRest = myDataReader[3].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("DataReader Client Data Conversion Error. Program Terminated. ",
                            "Client SELECT Error", MessageBoxButtons.OK);
                        this.Close();
                    }  // end try-catch
                }  // end else on myDataReader HasRows
            }  // end processing Client 

            else if (p.GetType() == typeof(Manager))     // Process MANAGER
            {
                myDataReader = dbFunctions.SelectPersonFromManager(Convert.ToInt32(txtPersonID.Text), out successFlag);
                myDataReader.Read();
                if (!myDataReader.HasRows)
                {
                    MessageBox.Show("DataReader returned null. No match found. DB and Serializable File not synched.  Program Terminated",
                        "Manager SELECT Error", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Manager record found and read.", "Manager Record Found", MessageBoxButtons.OK);
                    try
                    {
                        dbStringPerson = myDataReader[0].ToString() + "   " + myDataReader[1].ToString() + "   ";
                        dbStringPerson = dbStringPerson + ((DateTime)myDataReader[2]).ToString("MM/dd/yyyy") + Environment.NewLine;
                        dbStringRest = myDataReader[3].ToString() + "   " + Convert.ToDecimal(myDataReader[4]).ToString()
                            + "   " + Convert.ToDecimal(myDataReader[5]).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("DataReader Manager Data Conversion Error. Program Terminated. ",
                            "Manager SELECT Error", MessageBoxButtons.OK);
                        this.Close();
                    }  // end try-catch
                }  // end else on myDataReader HasRows
            }  // end Processing Manager

            else if (p.GetType() == typeof(Worker))   /// Process WORKER
            {
                myDataReader = dbFunctions.SelectPersonFromWorker(Convert.ToInt32(txtPersonID.Text), out successFlag);
                myDataReader.Read();
                if (!myDataReader.HasRows)
                {
                    MessageBox.Show("DataReader returned null. No match found. DB and Serializable File not synched.  Program Terminated",
                        "Worker SELECT Error", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Worker record found and read.  ", "Worker Record Found", MessageBoxButtons.OK);
                    try
                    {
                        dbStringPerson = myDataReader[0].ToString() + "   " + myDataReader[1].ToString() + "   "
                            + ((DateTime)myDataReader[2]).ToString("MM/dd/yyyy") + Environment.NewLine;
                        dbStringRest = myDataReader[3].ToString() + "   " + Convert.ToDecimal(myDataReader[4]).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("DataReader Worker Data Conversion Error. Program Terminated.",
                            "Worker SELECT Error", MessageBoxButtons.OK);
                        this.Close();
                    }  // end try-catch
                }  // end else on myDataReader HasRows
            }  // end processing Worker
            else
            {
                MessageBox.Show("Type of object to Edit/Update is not valid. Contact System Admin.", "Delete Object Type Error",
                    MessageBoxButtons.OK);
                MessageBox.Show("Number of records processed = " + recordsProcessedCount.ToString(),
                    "Exit Message", MessageBoxButtons.OK);
                this.Close();
            }  // end multiple alternative if
            MessageBox.Show(dbStringPerson + dbStringRest, "DataBase Retrieval", MessageBoxButtons.OK);
        }  // end displayDbInformation
        */

    }
}