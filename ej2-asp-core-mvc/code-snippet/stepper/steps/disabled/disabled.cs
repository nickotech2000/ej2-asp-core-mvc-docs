public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { IconCss = "sf-icon-cart" });
    stepperSteps.Add(new Step { IconCss = "sf-icon-transport" });
    stepperSteps.Add(new Step { IconCss = "sf-icon-payment", Disabled = true});
    stepperSteps.Add(new Step { IconCss = "sf-icon-success" });
    ViewBag.datasource = stepperSteps;
    
    return View();
}