# How to show the progress of loading image tiles


<p>This example shows how to visualize the progress of loading image tiles using a progress bar.</p>
<p>To accomplish this task, handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapImageTilesLayer_RequestDataLoadingtopic"><u>ImageTilesLayer.RequestDataLoading</u></a> event and specify how the progress bar should be updated using the <strong>UpdateProgressBar</strong> method. Then, handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapLayerBase_DataLoadedtopic"><u>LayerBase.DataLoaded</u></a> event to specify the final state of the progress bar when the data load is finished.</p>

<br/>


