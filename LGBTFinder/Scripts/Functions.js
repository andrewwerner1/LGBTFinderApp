
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
}