$(function() {
	/*------------------Content  Menu ------------------*/
	/*Ẩn các  item*/

	$('.item-menu').css('display', 'none');
	$('.item-menu').slideUp();
	$('.label-menu').click(function(event) {
	    /* Act on the event */
	    $(".label-menu").removeClass('boder-top');
	    $('.item-menu').slideUp();
		$(this).next().next().toggleClass('boder-top');
		$(this).next().slideToggle();
	});
	$("#AlertBox").removeClass("hide");
	$("#AlertBox").delay(1000).slideUp(500);

    
    

});