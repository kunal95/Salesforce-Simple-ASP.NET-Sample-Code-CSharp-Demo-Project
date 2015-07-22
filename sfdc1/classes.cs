using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sfdc1
{

    class Location__c
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Area_Name__c { get; set; }
        public string Zip_Code__c { get; set; }

    }
    class Rider__c
    {
        public string Name { get; set; }
        public string Email_id__c { get; set; }
        public string Name__c { get; set; }
        public string Phone_number__c { get; set; }
        public string Wallet__c { get; set; }
    }
    class Driver__c
    {
        public string Id { get; set; }
        public string Address__c { get; set; }
        public string Age__c { get; set; }
        public string License_Number__c { get; set; }
        public string Name__c { get; set; }
        public string Phone__c { get; set; }
        public string Status__c { get; set; }
        public string Vehicle__c { get; set; }
    }
    class Driver__c2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address__c { get; set; }
        public string Age__c { get; set; }
        public string Avg_Rating__c { get; set; }
        public string Distance_Travelled__c { get; set; }
        public string Number_Of_Journeys__c { get; set; }
        public string Payout__c { get; set; }
        public string Total_Earnings__c { get; set; }
        public string License_Number__c { get; set; }
        public string Name__c { get; set; }
        public string Phone__c { get; set; }
        public string Status__c { get; set; }
        public string Rating__c { get; set; }
        public string Vehicle__c { get; set; }
    }
    class Wallet
    {
        public string Name { get; set; }
        public string Bank__c { get; set; }
        public string Card_Type__c { get; set; }
        public string Credit_Card_Number__c { get; set; }
    }
    class Booking__c
    {
        public string Name { get; set; }
        public string Destination__c { get; set; }
        public string Pick_Up__c { get; set; }
        public string pick_up_time__c { get; set; }
        public string Rider__c { get; set; }

    }
    class Journey__c
    {
        public string Name { get; set; }
        public string Distance_kms__c { get; set; }
        public string Driver_c { get; set; }
        public string Rider_c { get; set; }
    }
    class Vehicle__c
    {
        public string Name { get; set; }
        public string Capacity__c { get; set; }
        public bool Insurance__c { get; set; }
        public string Insurance_Expiry__c { get; set; }
        public string Registration_Date__c { get; set; }
        public string Registration_Number__c { get; set; }
        public string Vehicle_Category__c { get; set; }
    }
    class Vehicle_Category__c
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category__c { get; set; }
        public string Charges__c { get; set; }
        public string Make_del__c { get; set; }

    }
}