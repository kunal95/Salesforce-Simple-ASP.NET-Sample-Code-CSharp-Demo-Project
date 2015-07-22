using Salesforce.Common;
using Salesforce.Force;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sfdc1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                var userName = "kunsachdeva@gmail.com";
                var password = "<password>";
                var passwordSecurityToken = "<passwordSecurityToken>";
                var consumerKey = "consumerKey";
                var consumerSecret = "<consumerSecret>";

                var auth = new AuthenticationClient();

                await auth.UsernamePasswordAsync(consumerKey, consumerSecret, userName, password + passwordSecurityToken);

                var forceClient = new ForceClient(auth.InstanceUrl, auth.AccessToken, auth.ApiVersion);
                Salesforce.Common.Models.QueryResult<Driver__c2> q = await forceClient.QueryAsync<Driver__c2>("SELECT Id,Name,Address__c,Age__c,Avg_Rating__c,Distance_Travelled__c,Number_Of_Journeys__c,Payout__c,Rating__c,Total_Earnings__c,License_Number__c,Name__c,Phone__c,Status__c,Vehicle__c FROM Driver__c WHERE Id='" + uniqueID.Value.Trim() + "'");
                if (q.Records.Count > 0)
                {
                    var d = q.Records[0];
                    tbody.InnerHtml = "<tr><td>" + "Name" + "</td><td>" + d.Name__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Age" + "</td><td>" + d.Age__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Avg Rating" + "</td><td>" + d.Avg_Rating__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Address" + "</td><td>" + d.Address__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Total Distance Travelled (KM)" + "</td><td>" + d.Distance_Travelled__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "No of journeys" + "</td><td>" + d.Number_Of_Journeys__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "License" + "</td><td>" + d.License_Number__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Payout" + "</td><td>" + d.Payout__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Phone" + "</td><td>" + d.Phone__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Rating" + "</td><td>" + d.Rating__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Current Status" + "</td><td>" + d.Status__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Earned Total" + "</td><td>" + d.Total_Earnings__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Cab ID" + "</td><td>" + d.Vehicle__c + "</td></tr>";
                }
                else
                {
                    var q2 = await forceClient.QueryByIdAsync<Rider__c>("Rider__c", uniqueID.Value.Trim());
                    tbody.InnerHtml = "<tr><td>" + "Name" + "</td><td>" + q2.Name__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Email" + "</td><td>" + q2.Email_id__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Phone" + "</td><td>" + q2.Phone_number__c + "</td></tr>";
                    tbody.InnerHtml += "<tr><td>" + "Wallet ID" + "</td><td>" + q2.Wallet__c + "</td></tr>";
                }
            }
            catch 
            {
            }
        }
    }
}