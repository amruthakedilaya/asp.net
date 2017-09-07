using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for EmployeeDL
/// </summary>
public class EmployeeDL
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;

    public EmployeeDL()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    }
    private void Open_Close_Connection()
    {
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        return;

    }
    public DataSet Get_Employees()
    {
        da = new SqlDataAdapter("Select * from employeedetails", con);
        ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void insertdata(EmployeeBL empBL)
    {
        cmd = new SqlCommand("Insert into employeedetails values(@id,@name,@gender,null,null,@country)", con);
        cmd.Parameters.AddWithValue("@id", empBL.Employee_ID);
        cmd.Parameters.AddWithValue("@name", empBL.Employee_NAME);
        cmd.Parameters.AddWithValue("@gender", empBL.Employee_GENDER);
        cmd.Parameters.AddWithValue("@country", empBL.Employee_COUNTRY);
        Open_Close_Connection();
    }
    public void Updatedata(EmployeeBL empBL)
    {
        cmd = new SqlCommand("update employeedetails set name= @name,gender = @gender,country=@country where id = @id", con);
        cmd.Parameters.AddWithValue("@name", empBL.Employee_NAME);
        cmd.Parameters.AddWithValue("@gender", empBL.Employee_GENDER);
        cmd.Parameters.AddWithValue("@country", empBL.Employee_COUNTRY);
        cmd.Parameters.AddWithValue("@id", empBL.Employee_ID);
        Open_Close_Connection();
    }
    public void Deletedata(EmployeeBL empBL)
    {
        cmd = new SqlCommand("Delete from employeedetails where id=@id ", con);
        cmd.Parameters.AddWithValue("@id", empBL.Employee_ID);
        Open_Close_Connection();

    }
}