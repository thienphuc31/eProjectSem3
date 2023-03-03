$(document).ready(function () {
    // Khởi tạo carousel
    $("#myCarousel").carousel({
        interval: 3000, // thời gian chuyển đổi giữa các ảnh
        pause: false, // không tạm dừng khi rê chuột lên
        wrap: true, // quay vòng lại ảnh đầu tiên khi đến ảnh cuối cùng
    });

    // Xử lý sự kiện click vào ảnh đầu tiên
    $("#myCarousel .carousel-item:first-child img").on("click", function () {
        window.location.href = "/News/Index";
    });

    // Xử lý sự kiện click vào ảnh thứ hai
    $("#myCarousel .carousel-item:nth-child(2) img").on("click", function () {
        window.location.href = "/Event/Index";
    });
});
