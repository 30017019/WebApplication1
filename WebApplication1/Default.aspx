<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="jumbotron md-12">         

        <asp:ScriptManager runat="server" ID="ScriptManager1">
            <Scripts>

                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

            <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
            <img src="imgs/banner_image.jpg" width = "100%" />
        </div>
        
        <div class="row">
            <div class="col-md-4" style="background-color:#333333">
                 <div class="row" >                                
                     <div class="col-md-12">
                        <h2 style="color:white; text-align:center;">Insert Data</h2>                            
                     </div>
                </div>
                        <div class="row">
                            <div class="col" >
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <center>
                                 <label id="lb1" style="color:white;">Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox9" runat="server" placeholder="Date"></asp:TextBox>
                                    
                                </div>
                                    </center>
                            </div>
                        </div>
                        <div class="row">
                           <div class="row-md-12">
                               <hr />
                               <center>
                                <label class="m-4" id="Label1" runat="server" style="color:white"> Enter Tempretures in Celcius only</label>
                               </center>
                            </div>
                             <div class="col-md-6">
                                 <center>
                                <label id="lb2" runat="server"  >00 am</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox1" runat="server" placeholder="00 am"></asp:TextBox>
                                </div>
                                     </center>
                            </div>
                            <div class="col-md-6">
                                <center>
                                <label id="lb3" runat="server">03 am</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox2" runat="server" placeholder="03 am"></asp:TextBox>
                                </div>
                                    </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <center>
                                <label id="lb4" runat="server">06 am</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox3" runat="server" placeholder="06 am"></asp:TextBox>
                                </div>
                                    </center>
                            </div>
                            <div class="col-md-6">
                                <center>
                                <label id="lb5" runat="server">09 am</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox4" runat="server" placeholder="09 am"></asp:TextBox>
                                </div>
                                    </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <center>
                                <label id="lb6" runat="server">12 pm</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox5" runat="server" placeholder="12 pm"></asp:TextBox>
                                </div>
                                    </center>
                            </div>
                            <div class="col-md-6">
                                <center>
                                <label id="lb7" runat="server">03 pm</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox6" runat="server" placeholder="03 pm"></asp:TextBox>
                                </div>
                                    </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <center>
                                <label id="lb8" runat="server">06 pm</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox7" runat="server" placeholder="06 pm"></asp:TextBox>
                                </div>
                                    </center>
                            </div>
                            <div class="col-md-6">
                                <center>
                                <label id="lb9" runat="server">09 pm</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="textbox8" runat="server" placeholder="09  pm"></asp:TextBox>
                                </div>
                                    </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <center>
                                <div class="form-group">
                                    <asp:Button CssClass="btn btn-success btn-block" Style="margin-left:auto; margin-right:auto; display:block;" ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" />
                                </div>
                                    </center>
                            </div>
                        </div>


            </div>
             <div class="col-md-8">
                <center>
                    
                    <h2 class="bg-primary" <h4 style="color:white; background-color:#333333" > 24 hours tempreture chart of chiller</h2>

                       <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pizzacutConnectionString %>" SelectCommand="SELECT * FROM [chillertemp] order by date desc"></asp:SqlDataSource>--%>
                        
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pizzacutConnectionString %>" SelectCommand="SELECT top 8 * FROM [chillertemp] order by date desc "></asp:SqlDataSource>
                        <asp:Chart ID="Chart1" CssClass="table table-bordered table-condensed table-responsive" runat="server" DataSourceID="SqlDataSource1" Width="1000px" BackImageWrapMode="Unscaled" OnLoad="Chart1_Load">
                            <Series>
                                <asp:Series ChartType="Spline" Name="Series1" XValueMember="time" YValueMembers="temp" BorderWidth="3" IsValueShownAsLabel="True" LabelBackColor="Transparent" LabelForeColor="DimGray">
                                    
                                    
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </center>
                 

               

            </div>

       </div>
    <hr />
    

       <div class="row">
           <div class="col-md-12" style="background-color:#eeeeee" >
                <center>
                                        
                                         <table class="auto-style1">
                                             <br />
                                              <tr>
                                                    <td class="auto-style1"><h4>Select Date &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4></td>
                                                          <td class="auto-style2">
                                                             <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="date" DataValueField="date" Width="400px" Height="50px">
                                                              </asp:DropDownList>
                                                          </td>
                                                     </tr>
                                          </table>
                                        
                        <br />
                     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:conn %>" SelectCommand="SELECT * FROM [chillertemp1]"></asp:SqlDataSource>               
                    
                    <asp:Button ID="Button1" runat="server" CssClass="btn" OnClick="Button1_Click1" Text="Submit" OnLoad="Page_Load" Height="48px" Width="1000px" BackColor="#333333" Font-Bold="True" Font-Size="Larger" ForeColor="White" />
                    
                     <ajaxToolkit:BarChart ID="BarChart1" runat="server" chartwidth="600" ChartHeight="450" BorderStyle="None" ChartType="StackedColumn" Font-Bold="true"  OnUnload="Page_Load" BaseLineColor="orange" BorderWidth="10" Font-Size="large" CategoriesAxis="Tempreture in Celcius" ForeColor="#FFFFCC" Visible="False"  >
                         
                         

                     </ajaxToolkit:BarChart>
                    <br />
                                    </center>
           </div>
       </div>
    
      
<br /><br />      
    
    <div class="row">
        <div class="col-md-4">
             <img src="imgs/deeppan.jpg" width="100%"/>
        </div>
         <div class="col-md-4">
             <img src="imgs/thincrispy.jpg" width="100%"/>
        </div>
         <div class="col-md-4">
             <img src="imgs/stuffcrust.jpg" width="100%"/>
        </div>
    </div>


        

            
               <div class="row ">
                <div class="col-md-4">
                    <center>
                   
                    <h2 class="bg-primary" style="background-color:#333333"> DEEP PAN</h2>
                    <p class="text-justify"> Our Pan Pizza is New Zealand’s favourite deep dish crust! The thick crust is baked to golden perfection, crispy on the outside, soft and chewy on the inside.</p>
                    </center>
                </div>

                <div class="col-md-4">
                    <center>
                    
                    <h2 class="bg-primary" style="background-color:#333333"> THIN N CRISPY</h2>
                    <p class="text-justify"> Our thinner crust baked to crispy perfection so you can taste more of your favourite toppings. Thin, crispy and tasty.</p>
                    </center>
                </div>

                <div class="col-md-4">
                    <center>
                    
                    <h2 class="bg-primary" style="background-color:#333333"> STUFFED CRUST</h2>
                    <p class="text-justify"> The extra playful pizza you eat backwards! Pizzeria-style crust with a ring of melted cheese baked right into the crust.</p>
                    </center>
                </div>
         
            </div>
           

        
              
        
                 
    
        
</asp:Content>
