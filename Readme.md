<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576789/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5183)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Map for WinForms - How to Show the Progress of Loading Image Tiles

This example shows how to visualize the progress of loading image tiles with a progress bar.
To accomplish this task, handle the [ImageTilesLayer.RequestDataLoading](https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapImageTilesLayer_RequestDataLoadingtopic) event and specify how the progress bar should be updated with the `UpdateProgressBar` method. Then, handle the [LayerBase.DataLoaded](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.LayerBase.DataLoaded) event to specify the final state of the progress bar when the data load is finished.

## Files to Review
* [Form1.cs](./CS/TilesLoaded/Form1.cs) (VB: [Form1.vb](./VB/TilesLoaded/Form1.vb))

## Documentation
[Map Image Data](https://docs.devexpress.com/WindowsForms/17853/controls-and-libraries/map-control/examples/map-image-data)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-show-the-progress-of-loading-image-tiles&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-show-the-progress-of-loading-image-tiles&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
