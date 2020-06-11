using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["pizzacutConnectionString"].ConnectionString;
        string strcon1 = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Chart1_Load(object sender, EventArgs e)
        //{
        //    try { 
        //    SqlConnection pizzacutConnectionString = new SqlConnection();
        //    if (pizzacutConnectionString.State == ConnectionState.Closed)
        //    {
        //        pizzacutConnectionString.Open();
        //    }

        //    SqlCommand cmd = new SqlCommand("select date,time,temp from chillertemp where date='02/05/2020'", pizzacutConnectionString);


        //    this.Chart1.DataSource = pizzacutConnectionString;

        //    //Mapping a field with x-value of chart
        //    this.Chart1.Series[1].XValueMember = "select time from chillertemp where date='02/05/2020";
        //    this.Chart1.Series[2].XValueMember = "select time from chillertemp where date='03/05/2020";

        //        //Mapping a field with y-value of Chart
        //        this.Chart1.Series[1].YValueMembers = "temp";

        //    //Bind the DataTable with Chart
        //    this.Chart1.DataBind();
        //    cmd.ExecuteNonQuery();

        //    pizzacutConnectionString.Close();
        //}
        //    catch (Exception ex)
        //    {

        //    }



        //    Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        //    Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        //    Chart1.ChartAreas["ChartArea1"].AxisX.Title = "Time";
        //    Chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tempreture in Celcius";

        //}



        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection pizzacutConnectionString = new SqlConnection();
                if (pizzacutConnectionString.State == ConnectionState.Closed)
                {
                    pizzacutConnectionString.Open();
                }

                SqlCommand cmd = new SqlCommand("select date,time,temp from chillertemp where date='01/05/2020'", pizzacutConnectionString);


                this.Chart1.DataSource = pizzacutConnectionString;

                //Mapping a field with x-value of chart
                this.Chart1.Series[1].XValueMember = "select time from chillertemp where date='02/05/2020";
                this.Chart1.Series[2].XValueMember = "select time from chillertemp where date='03/05/2020";


                //Mapping a field with y-value of Chart
                this.Chart1.Series[1].YValueMembers = "temp";
                //this.Chart1.Series[2].YValueMembers = "temp";

                //Bind the DataTable with Chart
                this.Chart1.DataBind();
                cmd.ExecuteNonQuery();

                pizzacutConnectionString.Close();
            }
            catch (Exception ex)
            {

            }



            Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            Chart1.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            Chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tempreture in Celcius";
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
            Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            BarChart1.Visible = true;
            decimal[] marks = new decimal[8];
            String[] subject = new string[8];
            String mycon = "Data Source=30017019.database.windows.net;Initial Catalog=pizzacut;Persist Security Info=True;User ID=a30017019;Password=ILOVEankit@4";
            String myquery = "Select * from chillertemp1 where date='" + DropDownList1.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                //marks[0] = char.Parse(ds.Tables[0].Rows[0]["time"].ToString());
                //marks[0] = Convert.ToString(ds.Tables[0].Rows[0]["date"].ToString());
                try
                {

                    marks[0] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp1"]);
                    marks[1] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp2"]);
                    marks[2] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp3"]);
                    marks[3] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp4"]);
                    marks[4] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp5"]);
                    marks[5] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp6"]);
                    marks[6] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp7"]);
                    marks[7] = Convert.ToDecimal(ds.Tables[0].Rows[0]["temp8"]);
                }
                catch (Exception ex) { }

                //marks[1] = decimal.Parse(ds.Tables[0].Rows[0]["temp"].ToString());
                //marks[1] = (decimal)ds.Tables[0].Rows[0]["temp"];

                subject[0] = "00 am";
                subject[1] = "03 am";
                subject[2] = "06 am";
                subject[3] = "09 am";
                subject[4] = "12 pm";
                subject[5] = "03 pm";
                subject[6] = "06 pm";
                subject[7] = "09 pm";
            }
            con.Close();
            BarChart1.Series.Add(new AjaxControlToolkit.BarChartSeries { Data = marks });
            BarChart1.CategoriesAxis = string.Join(",", subject);
            BarChart1.ChartTitle = "Chiller Tempreture - In Celcius as on " + DropDownList1.Text;




        }



        protected void btn1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('testing');</script>");
            try
            {


                SqlConnection conn = new SqlConnection(strcon1);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }



                SqlCommand cmd8 = new SqlCommand("insert into chillertemp1(date, temp1,temp2,temp3,temp4,temp5,temp6,temp7,temp8) values(@date,@temp1,@temp2,@temp3,@temp4,@temp5,@temp6,@temp7,@temp8)", conn);

                cmd8.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp1", textbox1.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp2", textbox2.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp3", textbox3.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp4", textbox4.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp5", textbox5.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp6", textbox6.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp7", textbox7.Text.Trim());
                cmd8.Parameters.AddWithValue("@temp8", textbox8.Text.Trim());
                cmd8.ExecuteNonQuery();

                conn.Close();
                //Response.Write("<script> alert('Record Added Successfully')</script>");
            }
            catch (Exception ex1)
            {

            }


            //Response.Write("<script>alert('testing');</script>");
            try
            {
                SqlConnection pizzacutConnectionString = new SqlConnection(strcon);
                if (pizzacutConnectionString.State == ConnectionState.Closed)
                {
                    pizzacutConnectionString.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd.Parameters.AddWithValue("@time", lb2.InnerText);
                cmd.Parameters.AddWithValue("@temp", textbox1.Text.Trim());
                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd1.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd1.Parameters.AddWithValue("@time", lb3.InnerText);
                cmd1.Parameters.AddWithValue("@temp", textbox2.Text.Trim());
                cmd1.ExecuteNonQuery();


                SqlCommand cmd2 = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd2.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd2.Parameters.AddWithValue("@time", lb4.InnerText);
                cmd2.Parameters.AddWithValue("@temp", textbox3.Text.Trim());
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd3.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd3.Parameters.AddWithValue("@time", lb5.InnerText);
                cmd3.Parameters.AddWithValue("@temp", textbox4.Text.Trim());
                cmd3.ExecuteNonQuery();


                SqlCommand cmd4 = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd4.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd4.Parameters.AddWithValue("@time", lb6.InnerText);
                cmd4.Parameters.AddWithValue("@temp", textbox5.Text.Trim());
                cmd4.ExecuteNonQuery();


                SqlCommand cmd5 = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd5.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd5.Parameters.AddWithValue("@time", lb7.InnerText);
                cmd5.Parameters.AddWithValue("@temp", textbox6.Text.Trim());
                cmd5.ExecuteNonQuery();


                SqlCommand cmd6 = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd6.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd6.Parameters.AddWithValue("@time", lb8.InnerText);
                cmd6.Parameters.AddWithValue("@temp", textbox7.Text.Trim());
                cmd6.ExecuteNonQuery();


                SqlCommand cmd7 = new SqlCommand("insert into chillertemp(date,time,temp) values(@date,@time,@temp)", pizzacutConnectionString);
                cmd7.Parameters.AddWithValue("@date", textbox9.Text.Trim());
                cmd7.Parameters.AddWithValue("@time", lb9.InnerText);
                cmd7.Parameters.AddWithValue("@temp", textbox8.Text.Trim());
                cmd7.ExecuteNonQuery();


                pizzacutConnectionString.Close();
                Response.Write("<script> alert('Record Added Successfully')</script>");
                Page.Response.Redirect(Page.Request.Url.ToString(), true);

            }
            catch (Exception ex)
            {

            }

        }
    }
}