using DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Models;
using WebClient.Views;
using WebFormsMvp;

namespace WebClient.Presenters
{
    public class CarsPresenter : Presenter<ICarsView>
    {
        private ICarService carsData;

        public CarsPresenter(ICarsView view, ICarService carsData) 
            : base(view)
        {
            this.carsData = carsData;

            this.View.PageLoad += View_PageLoad;
            this.View.SelectedIndexChanged += View_SelectedIndexChanged;
        }

        private void View_SelectedIndexChanged(object sender, CarsEventArgs e)
        {
            var producer = e.SelectedProducer;
            this.View.Model.Models = this.carsData.GetModelsByProducer(producer);
        }

        private void View_PageLoad(object sender, EventArgs e)
        {
            this.View.Model.Producers = this.carsData.GetProducers();
            this.View.Model.Extras = this.carsData.GetExtras();
        }
    }
}