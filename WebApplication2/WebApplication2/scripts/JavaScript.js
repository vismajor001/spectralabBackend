
function Purchase() {
    var url = "http://localhost:63454/Main.asmx"
         $.ajax({
             type: "POST",

             url: url + "/ListOfInventory",
             data: "",
             headers: {
                 'name-api-key': 'ewf45r4435trge',
                 'Content-Type': 'application/x-www-form-urlencoded'
             },
             dataType: "json",
             success: function (msg) {
                 console.log(msg)

             },
             error: function (e) {
                 console.log(e)
                 console.log(e.responseText)
                 
             }

         });
     }

Purchase();


function parseXml(xml) {
    var dom = null;
    if (window.DOMParser) {
        try {
            dom = (new DOMParser()).parseFromString(xml, "text/xml");
        }
        catch (e) { dom = null; }
    }
    else if (window.ActiveXObject) {
        try {
            dom = new ActiveXObject('Microsoft.XMLDOM');
            dom.async = false;
            if (!dom.loadXML(xml)) // parse error ..

                window.alert(dom.parseError.reason + dom.parseError.srcText);
        }
        catch (e) { dom = null; }
    }
    else
        alert("cannot parse xml string!");
    return dom;
}