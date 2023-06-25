function printInvoke() {
    $(".hideWhenPrint").hide();

    window.print();

    $(".hideWhenPrint").show();
}