---
layout: post
title: Globalization in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Globalization in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ##Platform_Name## Stepper control

## Localization

The Localization library allows you to localize the default text content of the Stepper. You can change the static text content used for the `Optional` property to other cultures (Arabic, Deutsch, French, etc.) by defining the `Locale` value and its translation object.

| Locale key | en-US (default) |
|-----|-----|
| optional | Optional |

In this example, the `French` culture is set to Stepper and the default text is updated with the content defined by the locale key.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/stepper/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Localization](images/stepper-locale.jpg)

## RTL

RTL provides an option to switch the text direction and layout of the Stepper control from right to left by setting the [EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_EnableRtl) property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RTL.cs" %}
{% include code-snippet/stepper/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper RTL](images/stepper-rtl.jpg)