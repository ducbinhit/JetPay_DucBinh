var Semantic = {
    Accordion:function() {
        $(".ui.accordion").accordion({
            selector: {
                trigger: ".title .icon"
            }
        });
    }
}

$(document).ready(function() {
    Semantic.Accordion();
    $(".show-modal-pending a").click(function () {
        $("#open-md").click();
    });
});