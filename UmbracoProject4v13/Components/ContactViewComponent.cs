
using UmbracoProject4v13.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;


[ViewComponent(Name = "Contact")]
public class ContactViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ContactViewModel model)
    {
        model ??= new ContactViewModel();

        return View(model);
    }
}