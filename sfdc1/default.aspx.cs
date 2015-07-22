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
    public partial class _default : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected async void booking_btn_Click(object sender, EventArgs e)
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
                
                Wallet wc = new Wallet { Bank__c = bankName.Value, Card_Type__c = cardType.Value, Credit_Card_Number__c = CardNo.Value };
                string x = await forceClient.CreateAsync("Wallet__c", wc);
                
                Rider__c rc = new Rider__c { Email_id__c = email.Value, Name__c = name.Value, Phone_number__c = contact.Value, Wallet__c = x };
                string x2 = await forceClient.CreateAsync("Rider__c", rc);
                
                Salesforce.Common.Models.QueryResult<Location__c> d1 = await forceClient.QueryAsync<Location__c>("SELECT Name,Id FROM Location__c WHERE Area_Name__c='" + dest.Value.Trim() + "'");
                Booking__c bc = new Booking__c { Destination__c = d1.Records[0].Id, Pick_Up__c = "a0728000000qCRg", pick_up_time__c = "2015-07-21T20:21:00Z", Rider__c = x2 };
                
                string x3 = await forceClient.CreateAsync("Booking__c", bc);
                Salesforce.Common.Models.QueryResult<Driver__c> d = await forceClient.QueryAsync<Driver__c>("SELECT Id,Address__c,Age__c,License_Number__c,Name__c,Phone__c,Status__c,Vehicle__c FROM Driver__c WHERE Status__c='For Hire'");
                d.Records[0].Status__c = "Hired";
                string ii = d.Records[0].Id;
                d.Records[0].Id = null;
                
                await forceClient.UpdateAsync("Driver__c", ii, d.Records[0]);

                Journey__c jc = new Journey__c { Distance_kms__c = rnd.Next(10, 100).ToString(), Rider_c = x2, Driver_c = ii };
                string x4 = await forceClient.CreateAsync("Journey__c", jc);
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(" + ex.Message + " - " + ex.InnerException + ")</script>");
            }
        }
    }
}