using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataServices;

namespace MobileSite.UserControls
{
    public partial class SearchMenu : System.Web.UI.UserControl
    {
        private CarsService carsData;

        public SearchMenu()
        {
            this.carsData = new CarsService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var producers = carsData.GetProducers();
                this.CarProducers.DataSource = producers;
                this.CarProducers.DataBind();

                var selsctedProducer = this.CarProducers.SelectedItem.Text;

                var modelsToSHow = carsData.GetModelsByProducer(selsctedProducer);

                this.Models.DataSource = modelsToSHow;
                this.Models.DataBind();

                var extras = this.carsData.GetExtras();
                this.Extras.DataSource = extras;
                this.Extras.DataBind();
            }
        }

        protected void CarProducers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selsctedProducer = this.CarProducers.SelectedItem.Text;
            var modelsToSHow = carsData.GetModelsByProducer(selsctedProducer);

            this.Models.DataSource = modelsToSHow;
            this.Models.DataBind();
        }

        protected void Submit(object sender, EventArgs e)
        {
            var producer = this.CarProducers.SelectedItem.Text;
            var model = this.Models.SelectedItem.Text;
            var extras = this.Extras.Items.Cast<ListItem>()
                                            .Where(i => i.Selected)
                                            .ToList();

            var result = new StringBuilder();
            result.AppendLine($"Selected Producer: {producer} <br/>");
            result.AppendLine($"Selected Model: {model} <br/>");
            result.AppendLine($"Selected Extras: {string.Join(", ", extras)} <br/>");

            this.Summary.Text = result.ToString();
        }
    }
}