console.log("Nodes.JS");

function createNode(){
    console.log($('#n_name').val());

    var data = {
        nodeName: $('#n_name').val(),
        link: $('#n_link').val(),
        text: $('#n_text').val()
    }

    $.ajax({
        type: 'POST',
        url: 'PostNode',
        dataType: 'json',
        contentType: 'application/json',
        data: JSON.stringify(data),
        success: function (result) {
            console.log('Data received');
            console.log(result);
        }
    });
}