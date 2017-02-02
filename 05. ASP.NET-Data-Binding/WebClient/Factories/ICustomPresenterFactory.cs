using System;
using WebFormsMvp;

namespace WebClient.Factories
{
    public interface ICustomPresenterFactory
    {
        IPresenter GetPresenter(Type presenterType, IView viewInstance);
    }
}