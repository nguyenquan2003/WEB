    // tăng só trên ô giỏ hàng
    let pickBtn = document.getElementsByClassName('product__main-info-cart-btn')[0];
    let cartInfo = document.getElementsByClassName('countProduct')[0];
    pickBtn.onclick = function() {
        let currentCount = Number(cartInfo.textContent);
        currentCount++;
        cartInfo.textContent = currentCount;

    };

    // ----------------------------------------------------------------------------------------
    const ttsp = document.querySelector('.ttsp');
    const dt = document.querySelector('.dt');
    const bh = document.querySelector('.bh');
    if (ttsp) {
        ttsp.addEventListener('click', function() {
            document.querySelector(
                '.product-content-right-button-content-ttsp'
            ).style.display = 'block';
            document.querySelector(
                '.product-content-right-button-content-dt'
            ).style.display = 'none';
            document.querySelector(
                '.product-content-right-button-content-bh'
            ).style.display = 'none';
        });
    }
    if (dt) {
        dt.addEventListener('click', function() {
            document.querySelector(
                '.product-content-right-button-content-ttsp'
            ).style.display = 'none';
            document.querySelector(
                '.product-content-right-button-content-dt'
            ).style.display = 'block';
            document.querySelector(
                '.product-content-right-button-content-bh'
            ).style.display = 'none';
        });
    }
    if (bh) {
        bh.addEventListener('click', function() {
            document.querySelector(
                '.product-content-right-button-content-ttsp'
            ).style.display = 'none';
            document.querySelector(
                '.product-content-right-button-content-dt'
            ).style.display = 'none';
            document.querySelector(
                '.product-content-right-button-content-bh'
            ).style.display = 'block';
        });
    }


    // ----------------------------------------------------------------------------------------
    const bigImg = document.querySelector('.product-content-left-big-img img');
    const samllImg = document.querySelectorAll(
        '.product-content-left-small-img img'
    );
    samllImg.forEach(function(imgItem, X) {
        imgItem.addEventListener('click', function() {
            bigImg.src = imgItem.src;
        });
    });