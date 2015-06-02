$(window).load(function () {
    $('.container').find('img').each(function () {
        var imgClass = (this.width / this.height > 1) ? 'wide' : 'tall';
        $(this).addClass(imgClass);
    })
})
$('.bxslider').bxSlider({
    minSlides: 4,
    maxSlides: 50,
    slideWidth: 250,
    ticker: true,
    speed: 40000
});