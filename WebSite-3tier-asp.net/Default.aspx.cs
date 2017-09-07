using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillGrid();

    }
    private void Clearall()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";

    }
    private void FillGrid()
    {
        EmployeeBL empBL = new EmployeeBL();
        GridView1.DataSource = empBL.GetEmployeeData();
        GridView1.DataBind();
        empBL = null;
    }

    private bool ValidateForm()
    {
        bool ret = true;
       
        if(string.IsNullOrEmpty(TextBox1.Text))
        {
            LabelID.Text = "ID is needed";
            ret= false;
        }
        else
        {
            LabelID.Text = "";
        }
        if (string.IsNullOrEmpty(TextBox2.Text))
        {
            LabelName.Text = "Name is needed";
            ret = false;
        }
        else
        {
            LabelName.Text = "";
        }
        if (string.IsNullOrEmpty(TextBox3.Text))
        {
            LabelGender.Text = "Gender is needed";
            ret = false;
        }
        else
        {
            LabelGender.Text = "";
        }
        if (string.IsNullOrEmpty(TextBox4.Text))
        {
            LabelCountry.Text = "Country is needed";
            ret = false;
        }
        else
        {
            LabelCountry.Text = "";
        }
        return ret;
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateForm())
                return;
            EmployeeBL empBL = new EmployeeBL();
            empBL.Employee_ID = Convert.ToInt64(TextBox1.Text);
            empBL.Employee_NAME = TextBox2.Text;
            empBL.Employee_GENDER = Convert.ToChar(TextBox3.Text);
            empBL.Employee_COUNTRY = TextBox4.Text;
            empBL.insertData(empBL);
            lblmsg.Text = "Data inserted successfully";
            FillGrid();
            Clearall();
            empBL = null;
        }
        catch(Exception ex)
        {
            throw ex;
        }

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            EmployeeBL empBL = new EmployeeBL();
            empBL.Employee_ID = Convert.ToInt64(TextBox1.Text);
            empBL.Employee_NAME = TextBox2.Text;
            empBL.Employee_GENDER = Convert.ToChar(TextBox3.Text);
            empBL.Employee_COUNTRY = TextBox4.Text;
            empBL.updateData(empBL);
            lblmsg.Text = "Data updated successfully";
            FillGrid();
            Clearall();
            empBL = null;
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            EmployeeBL empBL = new EmployeeBL();
            empBL.Employee_ID = Convert.ToInt64(TextBox1.Text);
            empBL.DeleteData(empBL);
            lblmsg.Text = "Data deleted successfully";
            FillGrid();
            Clearall();
            empBL = null;
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
}