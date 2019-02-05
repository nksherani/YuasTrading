
//

//<script>

// Default window ornaments for the live help dialog
var _liveHelpDialogFeature = "status=1,width=500,height=420,resizable=1";



function WriteLiveSupportButton()
{


	var ImageURL='https://yuasatrading.com/LiveChat/CuteSoft_Client/CuteChat/images/141x44-offline.gif';

	ImageURL= "<img title=\"support chat\" src=\""+ImageURL+"\" border=0 style=\"height:39px;\">";

	// write the live support button to the page
	document.write('<a href=\"javascript:void(0)\" onclick=\"OpenLiveSupport()\">'+ImageURL+'</a>');

}

WriteLiveSupportButton();

function OpenLiveSupport()
{
	var encode=escape
	if(typeof(encodeURIComponent)!="undefined")
		encode=encodeURIComponent;
		
	var url="https://yuasatrading.com/LiveChat/CuteSoft_Client/CuteChat/"+"SupportRedirect.aspx?Referrer="+encode(document.referrer)+"&Url="+encode(location.href)+"&_time="+(new Date().getTime());
	var win;
	try
	{
		win=window.open(url,'',_liveHelpDialogFeature);
	}
	catch(x)
	{
	}
	
	if(win==null)
	{
		alert("Pop-up Blocker Detected.");
	}
}


