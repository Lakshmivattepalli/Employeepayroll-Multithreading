using EmployeePayRollSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi1", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi2", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi3", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi4", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi5", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F',BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi6", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi7", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi8", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi9", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Lakshmi10", PhoneNumber: "9014120136", Address: "VDP", Department: "PROD", Gender: 'F', BasicPay: 3423, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5656, City: "banglore", Country: "india"));

            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            employeePayRollOperation.addEmployeeToPayRoll(employeeDetails);
        }
    }
}

