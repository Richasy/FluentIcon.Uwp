# Fluent icon library instructions

## Introduction

Microsoft has released a new icon font [fluentui-system-icons](https://github.com/microsoft/fluentui-system-icons). In order to facilitate the use in UWP projects, I customized a function to export icon font enumeration through the [Character-Map-UWP](https://github.com/character-map-uwp/Character-Map-UWP) project, and created the project with two IconElements.

## How to use

### Install nuget package

In the icons provided by Microsoft, there are two styles of `Filled` and `Regular`, so nuget packages are provided separately:

- [Richasy.FluentIcon.Regular.UWP](https://www.nuget.org/packages/Richasy.FluentIcon.Regular.UWP)
- [Richasy.FluentIcon.Filled.UWP](https://www.nuget.org/packages/Richasy.FluentIcon.Filled.UWP)

Please install one of them in your project (if necessary, you can also install both).

### Add icon element

Since the control inherits from `FontIcon`, you can use it as a separate control or insert it into the `Icon` property of some controls.

Before using, first introduce the namespace in the current XAML root element:

```
xmlns:fi="using:Richasy.FluentIcon.Uwp"
```

Then insert the control:

```xml
<fi:RegularFluentIcon Symbol="Play16" />
```

or

```xml
<AppBarButton Label="Add">
    <AppBarButton.Icon>
        <fi:RegularFluentIcon Symbol="Add16" />
    </AppBarButton.Icon>
</AppBarButton>
```

**The above demonstration is `RegularFluentIcon`, another is `FilledFluentIcon`, they have same use method.**

> The enumeration contains some size identifiers, and these values do not affect the actual icon size. The reason for keeping it is that I noticed that some icons are displayed differently under different sizes (such as `cloud_arrow_up`), some may have different glyphs, and some may have different thicknesses, so I still keep these identifiers.

## How to query icons

After all, enumeration cannot provide enough preview effects. If you want to browse all icons, you can do the following two ways:

1. Browse the icon list in the [Microsoft github repository](https://github.com/microsoft/fluentui-system-icons/blob/master/icons.md)
2. Use [Character Map UWP](https://www.microsoft.com/store/apps/9wzdncrdxf41?cid=storebadge&ocid=badge) to browse the installed icon fonts (recommended).

![](https://obohe.com/i/2021/07/24/ly5h64.png)
