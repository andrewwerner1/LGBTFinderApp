
function LocationOptionChoice() {
    $("#Choice2Section").show();
}

function InformationEntryChoice(entryType) {
    if (entryType === "manual") {
        $("#InformationFieldsSection").show();
        $("#UploadInformationSection").hide();
    }
    else if (entryType === "upload") {
        $("#InformationFieldsSection").hide();
        $("#UploadInformationSection").show();
    }
};

function CallZipcodeAPIFunction() {
    var javascriptZipcodeApiKey = '<%=ConfigurationSettings.AppSettings["ZipCodeAPIJavaScriptKey"].ToString() %>';
    var zipcode = $('Input#InputZipcode').val();
    var distance = $('select#SelectDistance').val();
    var distanceUnits = '<%=ConfigurationSettings.AppSettings["ZipCodeAPIUnits"].ToString() %>';
    $.ajax({
        "url" : "https://www.zipcodeapi.com/rest/" + javascriptZipcodeApiKey + "/radius.json/" + zipcode + "/" + distance + "/" + distanceUnits + "",
        "dataType" : "json" 
    }).done(function() {
        
    }).error(function() {
        
    });
};