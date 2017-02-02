using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using WebClient.Models;
using WebClient.Views;
using WebFormsMvp.Web;
using WebClient.Presenters;
using WebFormsMvp;

namespace WebClient.UserControls
{
    [PresenterBinding(typeof(CarsPresenter))]
    public partial class CarSearch : MvpUserControl<CarsViewModel>, ICarsView
    {
        public event EventHandler PageLoad;
        public event EventHandler<CarsEventArgs> SelectedIndexChanged;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PageLoad?.Invoke(sender, e);
                
                this.CarProducers.DataSource = this.Model.Producers;
                this.CarProducers.DataBind();

                var selsctedProducer = this.CarProducers.SelectedItem.Text;

                this.SelectedIndexChanged?.Invoke(sender, (new CarsEventArgs(selsctedProducer)));

                this.Models.DataSource = this.Model.Models;
                this.Models.DataBind();
                
                this.Extras.DataSource = this.Model.Extras;
                this.Extras.DataBind();
            }
        }

        protected void CarProducers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selsctedProducer = this.CarProducers.SelectedItem.Text;
            this.SelectedIndexChanged?.Invoke(sender, (new CarsEventArgs(selsctedProducer)));

            this.Models.DataSource = this.Model.Models;
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