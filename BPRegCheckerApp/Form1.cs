using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPRegCheckerApp.Models;


namespace BPRegCheckerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void InitPostRequest()
        {
            var client = new RestClient("https://driver-vehicle-licensing.api.gov.uk/vehicle-enquiry/v1/vehicles");
            var request = new RestRequest(Method.POST);

            request.AddHeader("x-api-key", "enter api key here");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", $"{{\n\t\"registrationNumber\":\"{txtInputtedReg.Text}\"\n}}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("No Reg Found", "No Reg Found");
            }

            Car car = JsonConvert.DeserializeObject<Car>(response.Content);
            lblResultMake.Text = car.make;
            lblResultColour.Text = car.colour;
            lblResultTaxStatus.Text = car.taxStatus;
            lblMOTExpiryDate.Text = car.motExpiryDate;
            lblResultEngineSize.Text = car.engineCapacity.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtInputtedReg.Text == "")
            {
                MessageBox.Show("Enter a Reg", "Enter a Reg");
            }
            string inputRegistration = txtInputtedReg.Text;

            InitPostRequest();

            Console.WriteLine(inputRegistration);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputtedReg.Text = "";
            lblResultMake.Text = "---";
            lblResultColour.Text = "---";
            lblResultTaxStatus.Text = "---";
            lblMOTExpiryDate.Text = "---";
        }
    }
}
