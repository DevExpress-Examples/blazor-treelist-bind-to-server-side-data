<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1234004)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Blazor TreeList - How to bind the component to DevExtreme data source with Entity Framework Core

This example uses the [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) data access technology to bind the [DevExpress Blazor TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) component to a [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1).

> [!IMPORTANT]
> The TreeList component is currently available as a community technology preview ([CTP](https://www.devexpress.com/aboutus/pre-release.xml)).

![Bind DevExpress Blazor TreeList to DevExtreme Data Source](/image.png)

You can use the [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) class to bind the DevExpress Blazor TreeList to a large [IQueryable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1) data collection. This data source implementation is based on our [DevExtreme.AspNet.Data](https://github.com/DevExpress/DevExtreme.AspNet.Data) library. When you use this data source, the TreeList delegates data filtering operations to an underlying query provider (such as [EF Core](https://docs.microsoft.com/en-us/ef/core/)) and loads node children when the node is expanded for the first time. This technique optimizes performance and reduces overall memory consumption.

To use this data source in your next Blazor project, follow the steps below:

1. Create a [GridDevExtremeDataSource\<T>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GridDevExtremeDataSource-1) class instance and pass your [IQueryable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1) data collection as the constructor parameter. Assign the result to the TreeList's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.Data) property.
2. Specify [KeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.KeyFieldName) and [ParentKeyFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ParentKeyFieldName) properties. The component uses them to build the tree.
3. Specify the [HasChildrenFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.HasChildrenFieldName) property. The component uses this property to determine which nodes require expand buttons.

## Files to Review

- [TreeList.razor](./CS/TreeListOnDemand/TreeListOnDemand/Components/Pages/TreeList.razor)
- [Location.cs](./CS/TreeListOnDemand/TreeListOnDemand/Data/Location.cs)
- [CitiesContext.cs](./CS/TreeListOnDemand/TreeListOnDemand/Data/CitiesContext.cs)
- [CitiesService.cs](./CS/TreeListOnDemand/TreeListOnDemand/Services/CitiesService.cs)
- [Program.cs](./CS/TreeListOnDemand/TreeListOnDemand/Program.cs)

## Documentation

- [Blazor TreeList (CTP)](https://docs.devexpress.com/Blazor/404942/components/treelist)
