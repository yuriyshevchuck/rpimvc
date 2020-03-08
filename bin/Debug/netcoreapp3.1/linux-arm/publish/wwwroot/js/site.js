// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#b1").click(function(){
    $.ajax({url: window.location.href + "api/GPIO/TurnOn", success: function(result){
        $("#div1").html(result);
    }});
});
$("#b2").click(function(){
    $.ajax({url: window.location.href + "api/GPIO/TurnOff", success: function(result){
        $("#div1").html(result);
    }});
});