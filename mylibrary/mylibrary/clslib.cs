using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace mylibrary
{
    public class clslib
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\haree\Documents\BSSE\computer collegiate\mylibrary\mylibrary\App_Data\dblib.mdf;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;

        string query;

        public void BindToDataList(string qry, DataList dl)
        {
            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            dl.DataSource = ds.Tables["tab"];
            dl.DataBind();
        }

        public void BindToGridView(string qry, GridView gv)
        {
            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            gv.DataSource = ds.Tables["tab"];
            gv.DataBind();
        }

        public void BindToDropDownlist(string qry, DropDownList dlst, string dtextfield, string dvaluefield)
        {
            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            dlst.DataSource = ds.Tables["tab"];
            dlst.DataTextField = dtextfield;
            dlst.DataValueField = dvaluefield;
            dlst.DataBind();
        }

        public bool SearchRecord(string tblName, string fieldName, string value)
        {
            query = "select * from " + tblName + " where " + fieldName + "='" + value + "'";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            if (ds.Tables["tab"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SearchRecord(string qry)
        {
            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            if (ds.Tables["tab"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string NewID(string tblName, string fieldName)
        {
            query = "select isnull(max(" + fieldName + "),0) + 1 as ID from " + tblName;
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            return ds.Tables["tab"].Rows[0]["ID"].ToString();
        }

        public string Manipulate(string qry, string work)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = qry;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                string Message = work + " Successful";
                return Message;
            }
            catch (Exception ex)
            {
                con.Close();
                string Message = work + " Failed";
                return Message;

            }


        }

        public string FindField(string tblName, string fieldName, string value, string ReqField)
        {
            query = "select * from " + tblName + " where " + fieldName + "='" + value + "'";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "tab");
            return ds.Tables["tab"].Rows[0][ReqField].ToString();
        }

    }
}