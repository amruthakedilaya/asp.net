using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBL
/// </summary>
public class EmployeeBL
{
    public Int64 Employee_ID { get; set; }

    public string Employee_NAME { get; set; }

    public char Employee_GENDER { get; set; }

    public string Employee_AGE { get; set; }

    public string Employee_SALARY { get; set; }

    public string Employee_COUNTRY { get; set; }


    public void insertData(EmployeeBL empBL)
    {
        EmployeeDL empDL = new EmployeeDL();
        empDL.insertdata(empBL);
        empDL = null;
    }

    public DataSet GetEmployeeData()
    {
        EmployeeDL empDL = new EmployeeDL();
        return empDL.Get_Employees();
        
    }

    public void updateData(EmployeeBL empBL)
    {
        EmployeeDL empDL = new EmployeeDL();
        empDL.Updatedata(empBL);
        empDL = null;
    }

    public void DeleteData(EmployeeBL empBL)
    {
        EmployeeDL empDL = new EmployeeDL();
        empDL.Deletedata(empBL);
        empDL = null;
    }
}