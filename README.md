<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/803737245/24.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1234004)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor TreeList - How to bind the component to DevExtreme data source with Entity Framework Core

This example uses [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) data access technology to bind the [DevExpress Blazor TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) component to a [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1).

![Bind DevExpress Blazor TreeList to DevExtreme Data Source](/image.png)

You can use the [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) class to bind the DevExpress Blazor TreeList to a large [IQueryable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1) data collection. This data source implementation is based on our [DevExtreme.AspNet.Data](https://github.com/DevExpress/DevExtreme.AspNet.Data) library. When you use this data source, the TreeList delegates data filtering operations to an underlying query provider (such as [EF Core](https://docs.microsoft.com/en-us/ef/core/)) and loads node children when a node is expanded for the first time. This technique optimizes performance and reduces overall memory consumption.

To use this data source in your next Blazor project, follow the steps below:

1. Create a [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) class instance and pass your [IQueryable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1) data collection as the constructor parameter. Assign the result to the TreeList's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Data) property.
2. Specify [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.KeyFieldName) and [ParentKeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ParentKeyFieldName) properties. The TreeList uses these properties to build its tree.
3. Specify the [HasChildrenFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.HasChildrenFieldName) property. The TreeList uses this property to determine which nodes require expand buttons.

## Files to Review

- [TreeList.razor](./CS/TreeListOnDemand/TreeListOnDemand/Components/Pages/TreeList.razor)
- [Location.cs](./CS/TreeListOnDemand/TreeListOnDemand/Data/Location.cs)
- [CitiesContext.cs](./CS/TreeListOnDemand/TreeListOnDemand/Data/CitiesContext.cs)
- [CitiesService.cs](./CS/TreeListOnDemand/TreeListOnDemand/Services/CitiesService.cs)
- [Program.cs](./CS/TreeListOnDemand/TreeListOnDemand/Program.cs)

## Documentation

- [Blazor TreeList (CTP)](https://docs.devexpress.com/Blazor/404942/components/treelist)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-treelist-bind-to-server-side-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-treelist-bind-to-server-side-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
