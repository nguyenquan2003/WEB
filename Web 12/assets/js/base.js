/*{ <a class="fa fa-facebook"></a>
<a class="fa fa-twitter"></a>
<a class="fa fa-google"></a>
<a class="fa fa-youtube"></a>} */

function addProducts(){
    document.write(`
    <div class="contaiter">
        <div class="grid">
            <div class=" main">
            <div class="product">
                <div class="grid__row">
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="/SP1.html" class="product-item">
                            <div class="product-item__img">  <img src="./assets/img/products/sp1.jpg"></div>
                            <h4 class="product-item__name">Đế 4 PIN AA có nắp</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">25 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">56000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>

                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp20.webp"> </div>
                            <h4 class="product-item__name">Bộ cấp nguồn/ Adaptor Dell 19.5V-6.67A-130W (Đầu kim nhỏ) (4.5mm*3.0mm) Zin (NQ)</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">62 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">785000 <i class="fa-solid fa-dong-sign"></i></span>
                                <span class="product-item__price-old">59000  <i class="fa-solid fa-dong-sign"></i></span>
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>

                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp3.png"> </div>
                            <h4 class="product-item__name">Raspberry Pi 4 Model B 2019 Bản 4G</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">88 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">1200000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp5.webp"> </div>
                            <h4 class="product-item__name">MẠCH BẢO VỆ VNBMS 3.2V 4S 100A (20 MOSFET)</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">188 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">499000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp10.webp"> </div>
                            <h4 class="product-item__name">Đồng hồ vạn năng Sanwa PS8a (Pin mặt trời, 0.7%)</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">26 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">499000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>

                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp12.webp"></div>
                            <h4 class="product-item__name">Dây nguồn AC 220V C13 EU 10A 3x0.75 1.8 mét / lõi đồng nguyên chất</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->
                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">51 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">36000 <i class="fa-solid fa-dong-sign"></i></span>
                                <span class="product-item__price-old">41000  <i class="fa-solid fa-dong-sign"></i></span>
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp13.webp"> </div>
                            <h4 class="product-item__name">Đầu cốt kim PTV1.25-10 màu xanh - túi 100 cái - S2H17</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">99 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">38000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp14.webp"> </div>
                            <h4 class="product-item__name">Rơ le bán dẫn DC-AC 3 pha SSR 100A FDR3-D48100Z chính hãng FULRD</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">62 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">1050000 <i class="fa-solid fa-dong-sign"></i></span>
                                <span class="product-item__price-old">1150000  <i class="fa-solid fa-dong-sign"></i></span>
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp15.jpg"> </div>
                            <h4 class="product-item__name">Sạc Apple 20W MHJE3</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">18 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">520000 <i class="fa-solid fa-dong-sign"></i></span>
                                <span class="product-item__price-old">600000  <i class="fa-solid fa-dong-sign"></i></span>
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp19.webp"> </div>
                            <h4 class="product-item__name">Mainboard ASUS PRIME H510M-K</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">32 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">1689000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>

                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp11.webp"> </div>
                            <h4 class="product-item__name">Mạch điều khiển quạt điều hòa từ xa - Mạch khiển quạt G3</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">94 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">75000 <i class="fa-solid fa-dong-sign"></i></span>
                                <span class="product-item__price-old">89000  <i class="fa-solid fa-dong-sign"></i></span>
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp4.webp"> </div>
                            <h4 class="product-item__name">Combo 10 Nút Nhấn Dán 2 Chân 3x6x2.5mm</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">265 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">499000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp16.jpeg"> </div>
                            <h4 class="product-item__name">Cáp Micro USB 0.2m AVA Speed II</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">385 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">20000 <i class="fa-solid fa-dong-sign"></i></span>
                                <span class="product-item__price-old"> 29000 <i class="fa-solid fa-dong-sign"></i></span> 
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp17.jpg"> </div>
                            <h4 class="product-item__name">Router Wifi Chuẩn Wifi 6 Asus AX1800HP</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">11 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">1890000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp9.webp"> </div>
                            <h4 class="product-item__name">Bộ khuếch đại công suất 160W x 2 qua WIFI, Blutooth Chất lượng âm thanh lossless</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">8 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">3490000 <i class="fa-solid fa-dong-sign"></i></span>
                                <span class="product-item__price-old">3990000  <i class="fa-solid fa-dong-sign"></i></span>
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    
                    <!-- 1 sản phẩm -->
                    <div class="grid__column-2-4 product-position">
                        <a href="./SP1.html" class="product-item">
                            <div class="product-item__img" >  <img src="./assets/img/products/sp18.jpg"> </div>
                            <h4 class="product-item__name">SSD SamSung 990 PRO 2TB M.2 PCIe gen 4 NVMe (MZ-V9P2T0BW)</h4>
                            <div class="product-item__action ">
                                <!-- <span class="product-item__like product-item__like--liked">
                                    <i class="product-item__like-icon-empty fa-regular fa-heart"></i>
                                    <i class="product-item__like-icon-fill fa-solid fa-heart "></i>
                                </span> -->

                                <div class="product-item__rating">
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="product-item__star--gold fa-solid fa-star"></i>
                                    <i class="fa-solid fa-star"></i>
                                </div>
                                <span class="product-item__sold">21 đã bán</span>
                            </div>
                            <div class="product-item__price">
                                <span class="product-item__price-current">7580000 <i class="fa-solid fa-dong-sign"></i></span>
                                <!-- <span class="product-item__price-old">899000  <i class="fa-solid fa-dong-sign"></i></span> -->
                            </div>
                            <div class="buy-btn">
                                <button>Mua ngay</button>
                            </div>
                            
                        </a>
                        <div class="quick-action">
                            <a onclick="addCart(this)" class="add_cart" title="Thêm vào giỏ hàng"></a>
                            <a class="like" href="" title="Thêm vào yêu thích"></a>
                        </div>
                    </div>
                    <div class="grid__column-2-4">
                        <!-- để sản phẩm vào đây -->
                    </div>
                </div>
            </div>
            </div>
            <div class="sidebar">
                <div class="sidebar_title">
                    <a href="">Sản phẩm nổi bật</a>
                    <!-- <a href="">Mua nhiều</a><a href="">Ưa thích</a> -->

                </div>
                <ul class="sidebar_content">
                    <li class="sidebar_content-item">
                        <a href="" class="sidebar-product">
                            <div class="sidebar_product-img">
                                <img src="./assets/img/products/sp2.jpg" alt="">
                            </div>
                            <div class="sidebar_product-content">
                                <p class="sidebar_product-title">Jack cắm âm thanh 3.5mm Paliccs</p>
                                <span class="sidebar_product-info">
                                    <i class="product-item__star--gold fa-solid fa-star"></i> 4.5
                                    <span class="sidebar_product-info--description space">Đã bán 102</span>
                                </span>
                            </div>
                        </a>
                    </li>
                    
                    <li class="sidebar_content-item">
                        <a href="" class="sidebar-product">
                            <div class="sidebar_product-img">
                                <img src="./assets/img/products/sp5.webp" alt="">
                            </div>
                            <div class="sidebar_product-content">
                                <p class="sidebar_product-title">Mạch phun sương, bộ mạch phun sương 25W RK-83</p>
                                <span class="sidebar_product-info">
                                    <i class="product-item__star--gold fa-solid fa-star"></i> 4.8
                                    <span class="sidebar_product-info--description space">Đã bán 102</span>
                                </span>
                            </div>
                        </a>
                    </li>
                    
                    <li class="sidebar_content-item">
                        <a href="" class="sidebar-product">
                            <div class="sidebar_product-img">
                                <img src="./assets/img/products/sp7.webp" alt="">
                            </div>
                            <div class="sidebar_product-content">
                                <p class="sidebar_product-title">Bộ trạm hàn BAKON White Light BK90 công xuất 90W 220V G9-5</p>
                                <span class="sidebar_product-info">
                                    <i class="product-item__star--gold fa-solid fa-star"></i> 4.8
                                    <span class="sidebar_product-info--description space">Đã bán 14</span>
                                </span>
                            </div>
                        </a>
                    </li>
                    
                    <li class="sidebar_content-item">
                        <a href="" class="sidebar-product">
                            <div class="sidebar_product-img">
                                <img src="./assets/img/products/sp8.webp" alt="">
                            </div>
                            <div class="sidebar_product-content">
                                <p class="sidebar_product-title">Bộ trạm hàn khò 2 trong 1, máy hàn khò BAKON White Light BK881 90W 220V G1-5</p>
                                <span class="sidebar_product-info">
                                    <i class="product-item__star--gold fa-solid fa-star"></i> 4.4
                                    <span class="sidebar_product-info--description space">Đã bán 112</span>
                                </span>
                            </div>
                        </a>
                    </li>
                    
                    <li class="sidebar_content-item">
                        <a href="" class="sidebar-product">
                            <div class="sidebar_product-img">
                                <img src="./assets/img/products/sp21.webp" alt="">
                            </div>
                            <div class="sidebar_product-content">
                                <p class="sidebar_product-title">Mainboard MSI PRO Z690-A DDR4</p>
                                <span class="sidebar_product-info">
                                    <i class="product-item__star--gold fa-solid fa-star"></i> 4.7
                                    <span class="sidebar_product-info--description space">Đã bán 7</span>
                                </span>
                            </div>
                        </a>
                    </li>
                    
                    <li class="sidebar_content-item">
                        <a href="" class="sidebar-product">
                            <div class="sidebar_product-img">
                                <img src="./assets/img/products/sp22.webp" alt="">
                            </div>
                            <div class="sidebar_product-content">
                                <p class="sidebar_product-title">Nguồn máy tính CORSAIR RM850e - 850W - 80 Plus Gold - Full Modular (CP-9020249-NA)</p>
                                <span class="sidebar_product-info">
                                    <i class="product-item__star--gold fa-solid fa-star"></i> 4.9
                                    <span class="sidebar_product-info--description space">Đã bán 14</span>
                                </span>
                            </div>
                        </a>
                    </li>
                    
                    <li class="sidebar_content-item">
                        <a href="" class="sidebar-product">
                            <div class="sidebar_product-img">
                                <img src="./assets/img/products/sp23.webp" alt="">
                            </div>
                            <div class="sidebar_product-content">
                                <p class="sidebar_product-title">Sạc Laptop HP 19V-4.74A-90W (Đầu kim) (7.4mm*5.0mm) (NQ)</p>
                                <span class="sidebar_product-info">
                                    <i class="product-item__star--gold fa-solid fa-star"></i> 4.1
                                    <span class="sidebar_product-info--description space">Đã bán 55</span>
                                </span>
                            </div>
                        </a>
                    </li>
                    
                </ul>
            </div>


            <div class="sidebar"  style="margin-top: 30px;">
                <div class="sidebar_title">
                    <a href="">Tìm kiếm nhiều nhất</a>
                    <!-- <a href="">Mua nhiều</a><a href="">Ưa thích</a> -->

                </div>
                <ul class="sidebar_content">
                    <li class="sidebar_search-item" style="margin-top: 20px;"><a href="">Mạch quạt điều hòa</a></li>
                    <li class="sidebar_search-item" ><a href="">Phun sương hơi nước</a></li>
                    <li class="sidebar_search-item" ><a href="">Module chuyển nhiệt</a></li>
                    <li class="sidebar_search-item" ><a href="">Mạch điều khiển led</a></li>
                    <li class="sidebar_search-item" ><a href="">Pin MT</a></li>
                    <li class="sidebar_search-item" ><a href="">Máy bơm phun sương</a></li>
                    <li class="sidebar_search-item" ><a href="">Nguồn adapter</a></li>
                    <li class="sidebar_search-item" ><a href="">Tản nhiệt TEC1</a></li>
                    <li class="sidebar_search-item xemthem" ><a href="">Xem thêm...</a></li>
                    
                </ul>
            </div>

            <div class="sidebar"  style="margin-top: 30px;">
                <div class="sidebar_title">
                    <a href="">Được mua nhiều nhất</a>
                    <!-- <a href="">Mua nhiều</a><a href="">Ưa thích</a> -->

                </div>
                <ul class="sidebar_content">
                    <li class="sidebar_search-item" style="margin-top: 20px;"><a href="">Mạch quạt điều hòa</a></li>
                    <li class="sidebar_search-item" ><a href="">Phun sương hơi nước</a></li>
                    <li class="sidebar_search-item" ><a href="">Module chuyển nhiệt</a></li>
                    <li class="sidebar_search-item" ><a href="">Mạch điều khiển led</a></li>
                    <li class="sidebar_search-item" ><a href="">Pin MT</a></li>
                    <li class="sidebar_search-item" ><a href="">Máy bơm phun sương</a></li>
                    <li class="sidebar_search-item" ><a href="">Nguồn adapter</a></li>
                    <li class="sidebar_search-item" ><a href="">Tản nhiệt TEC1</a></li>
                    <li class="sidebar_search-item xemthem" ><a href="">Xem thêm...</a></li>
                    
                </ul>
            </div>
        </div>
        
    </div>
    

    `)
}


// Thêm topnav vào trang
function addTopNav() {  
    document.write(`    
	<div class="top-nav group">
        <section>
            <div class="social-top-nav">
                <a class="fa-brands fa-facebook-f"></a>
                <a class="fa-brands fa-instagram"></a>
                <a class="fa-brands fa-twitter"></a>
                <a class="fa-brands fa-youtube"></a>

            </div> <!-- End Social Topnav -->

            <ul class="top-nav-quicklink flexContain">
                <li><a href="TrangChu.html"><i class="fa fa-home"></i> Trang chủ</a></li>
                <li><a href="#"><i class="fa-regular fa-newspaper"></i> Tin tức</a></li>
                <li><a href="#"><i class="fa-regular fa-handshake"></i></i> Tuyển dụng</a></li>
                <li><a href="gioithieu.html"><i class="fa fa-info-circle"></i> Giới thiệu</a></li>
                <li><a href="#"><i class="fa fa-wrench"></i> Bảo hành</a></li>
                <li><a href="lienhe.html"><i class="fa fa-phone"></i> Liên hệ</a></li>
            </ul> <!-- End Quick link -->
        </section><!-- End Section -->
    </div><!-- End Top Nav  -->`);
}

// Thêm header
function addHeader() {
    document.write(`        
	<div class="header group">
        <div class="menu">
            <i class="menu-icon fa-solid fa-bars"></i>                                                                                                                                                      
            <p class="sub_navbar-text">Danh mục sản phẩm</p>
            <div class="menu-content">
                <ul class="menu-list">					
                        <a href="">
                            <i class="fa-solid fa-magnifying-glass-arrow-right"></i> IC - Mạch Tích Hợp
                        </a>
                        
                        <a href=""><i class="fa-solid fa-magnifying-glass-arrow-right"></i> Mạch Điện, Module, Thiết Bị Nạp</a>
                        
                        <a href=""><i class="fa-regular fa-star"></i> LCD, LED, Tấm Cảm Ứng</a>
                        
                        <a href=""><i class="fa-regular fa-star"></i> Cổng Kết Nối, Đầu Nối, Jack Nối</a>
                        
                        <a href=""><i class="fa-regular fa-star"></i> Dây Điện, Cáp Điện, Dây Tín Hiệu</a>
                        
                        <a href=""><i class="fa-regular fa-heart"></i> Module - Cảm Biến</a>
                        
                        <a href=""><i class="fa-solid fa-tags"></i> Bộ Nguồn Điện, Pin, Biến Áp</a>
                        
                        <a href=""><i class="fa-solid fa-tags"></i> Phụ Kiện Máy Tính, Điện Dân Dụng</a>
                        
                        <a href=""><i class="fa-solid fa-thumbtack"></i> Phụ Kiện Điện Thoại</a>
                        
                        <a href=""><i class="fa-solid fa-thumbtack"></i> Điều Khiển Các Loại</a>
                </ul>
            </div> <!-- End Logo -->
        </div>
        

        <div class="content">
            <div class="search-header" style="position: relative; left: 162px; top: 1px;">
                <form class="input-search" method="get" action="trangchu.html">
                    <input id="search-box" name="search" autocomplete="off" type="text" placeholder="Nhập tên sản phẩm muốn tìm">
                    <button class="submit">
                        <i class="fa-solid fa-magnifying-glass"></i>
                    </button>
                </form> <!-- End Form search -->

            </div> <!-- End Search header -->

            <div class="tools-member">
            
            <div class="cart">
                <a href="giohang.html">
                    <i class="fa fa-shopping-cart"></i>
                    <span>Giỏ hàng</span>
                    <span class="cart-number"></span>
                </a>
            </div> <!-- End Cart -->
            
            <!--Notice-->
            <div class="notice">
                
                <i class="fas fa-bell notification-icon"></i>
                <div class="notification-badge">1</div>
                <div class="notification-hover">
                <svg viewBox="0 0 24 24" preserveAspectRatio="xMidYMid meet" focusable="false" class="notice-empty">
                    <g class="style-scope notice-empty">
                    <path
                        d="M10,20h4c0,1.1-0.9,2-2,2S10,21.1,10,20z M20,17.35V19H4v-1.65l2-1.88v-5.15c0-2.92,1.56-5.22,4-5.98V3.96 c0-1.42,1.49-2.5,2.99-1.76C13.64,2.52,14,3.23,14,3.96l0,0.39c2.44,0.75,4,3.06,4,5.98v5.15L20,17.35z M19,17.77l-2-1.88v-5.47 c0-2.47-1.19-4.36-3.13-5.1c-1.26-0.53-2.64-0.5-3.84,0.03C8.15,6.11,7,7.99,7,10.42v5.47l-2,1.88V18h14V17.77z"
                        class="style-scope notice-empty"
                        ></path>
                    </g>
                </svg>
                <div class="mes">Hiện không có thông báo</div>
                </div>
               
            </div>
            

            <div class="member">
                <a onclick="checkTaiKhoan()">
                    <i class="fa fa-user"></i>
                </a>
                <ul class="menuMember hide">
                    <a href="FORM_DKDN/formDN.html" class="member-item">
                        <i class="fa-solid fa-right-to-bracket"></i>
                        Đăng nhập
                    </a>
                    <a href="FORM_DKDN/formDK.html" class="member-item">
                        <i class="fa-solid fa-user-plus"></i>
                        Đăng ký
                    </a>
                </ul>
                

            </div> <!-- End Member -->

                <!--<div class="check-order">
                    <a>
                        <i class="fa fa-truck"></i>
                        <span>Đơn hàng</span>
                    </a>
                </div> -->
            </div><!-- End Tools Member -->
        </div> <!-- End Content -->
    </div> <!-- End Header -->`)
}

function addFooter(){
    document.write(`
    <div class="footer">
    <div class="footer-top">
            <div class="col">
                    <ul class="list-footer">
                            <li class="item-footer"><a href="#" class="link-footer">Thiên đường mua sắm HUFI</a></li>
                            <li class="item-footer"><a href="#" class="link-footer">Công ty cổ phần thương mại
                                    HUFI</a></li>
                            <li class="item-footer"><a href="#" class="link-footer">Địa chỉ: 140 Lê Trọng Tấn,
                                    P. Tây Thạnh, Q. Tân Phú, TP.HCM</a></li>
                            <li class="item-footer"><a href="#" class="link-footer">Điện thoại: 0123456789</a></li>
                            <li class="item-footer"><a href="#" class="link-footer">Email: infor@hufi.edu.vn</a>
                            </li>
                                            
                    </ul>
                    <!-- bản đồ -->
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.0672546543356!2d106.62712494088763!3d10.806161029376405!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752be27d8b4f4d%3A0x92dcba2950430867!2zVHLGsOG7nW5nIMSQ4bqhaSBo4buNYyBDw7RuZyBuZ2hp4buHcCBUaOG7sWMgcGjhuqltIFRQLkhDTQ!5e0!3m2!1svi!2s!4v1681912304978!5m2!1svi!2s"
                            width="100%" height="200" style="border:0;" allowfullscreen="" loading="lazy"
                            referrerpolicy="no-referrer-when-downgrade"></iframe>

            </div>

            <div class="col">
                    <div class="infor">
                            <h3 class="text3">Về chúng tôi</h3>
                            <ul>
                                    <li class="text2"><a href="#">Giới thiệu</a></li>
                                    <li class="text2"><a href="#">Chính sách bảo mật</a></li>
                                    <li class="text2"><a href="#">Điều khoản</a></li>
                                    <li class="text2"><a href="#">Chính sách trả góp</a></li>
                                    <li class="text2"><a href="#">Qui định chung</a></li>
                            </ul>
                    </div>


                    <!-- fanpage -->
                    <iframe name="f27b86b4ac2495" width="1000px" height="1000px" data-testid="fb:page Facebook Social Plugin" title="fb:page Facebook Social Plugin" frameborder="0" allowtransparency="true" allowfullscreen="true" scrolling="no" allow="encrypted-media" src="https://www.facebook.com/v2.0/plugins/page.php?adapt_container_width=true&amp;app_id=&amp;channel=https%3A%2F%2Fstaticxx.facebook.com%2Fx%2Fconnect%2Fxd_arbiter%2F%3Fversion%3D46%23cb%3Df39897f45ec3838%26domain%3Dts.hufi.edu.vn%26is_canvas%3Dfalse%26origin%3Dhttps%253A%252F%252Fts.hufi.edu.vn%252Ff202f5f2c3b87c8%26relation%3Dparent.parent&amp;container_width=300&amp;hide_cover=false&amp;href=https%3A%2F%2Fwww.facebook.com%2FTuyensinhHUFI%2F&amp;locale=en_US&amp;sdk=joey&amp;show_facepile=true&amp;small_header=false&amp;tabs=&amp;width=" style="border: none; visibility: visible; width: 300px; height: 130px;" class=""></iframe>

                    <!-- đăng kí nhận thông tin ưu đãi  -->

                    <div class="sign-up">
                            <h3>Đăng ký nhận ưu đãi khủng từ HUFI</h3>
                            <input placeholder="Email của bạn là" type="text" inputmode="email" value="" class="email">
                            <button type="submit" value="Submit" class="dang-ky"><span>Đăng ký</span></button>
                            <img src="https://nguyenvanhieu.vn/wp-content/uploads/2020/07/hot-icon.gif" decoding="async" class=" lazy-loaded">
                    </div>
            </div>
            

            <div class="col">
                    <div class="payment"> <!-- phương thức thanh toán -->
                            <p>Phương thức thanh toán</p>
                            <!-- <img src="qrcode.png" alt="" class="qr-code"> -->
                            <a target="_blank" rel="noopener noreferrer" class="_2pbE-b"><img
                                            src="https://down-vn.img.susercontent.com/file/d4bbea4570b93bfd5fc652ca82a262a8"
                                            alt="logo"></a>
                            <a target="_blank" rel="noopener noreferrer" class="_2pbE-b"><img
                                            src="https://down-vn.img.susercontent.com/file/a0a9062ebe19b45c1ae0506f16af5c16"
                                            alt="logo"></a>
                            <a target="_blank" rel="noopener noreferrer" class="_2pbE-b"><img
                                            src="https://down-vn.img.susercontent.com/file/38fd98e55806c3b2e4535c4e4a6c4c08"
                                            alt="logo"></a>
                            <a target="_blank" rel="noopener noreferrer" class="_2pbE-b"><img
                                            src="https://down-vn.img.susercontent.com/file/5e3f0bee86058637ff23cfdf2e14ca09"
                                            alt="logo"></a>
                            <svg width="32" height="33" fill="none">
                                    <path d="M7.84552 7.93196L26.906 5.14548C25.8411 4.2238 24.4546 3.6665 22.9395 3.6665H9.06047C5.70863 3.6665 3 6.38153 3 9.72531V23.5934C3 26.6014 5.19406 29.1021 8.06707 29.5736L5.54426 11.0185C5.32985 9.5324 6.38043 8.14631 7.84552 7.93196Z"
                                            fill="#0068FF"></path>
                                    <path d="M26.906 5.14589L7.84551 7.93237C6.38042 8.14671 5.33698 9.53995 5.55139 11.0261L8.06706 29.5812C8.38866 29.6312 8.72456 29.6669 9.06046 29.6669H22.9395C26.2914 29.6669 29 26.9519 29 23.6081V9.71857C28.9928 7.8895 28.1924 6.25334 26.906 5.14589Z"
                                            fill="white"></path>
                                    <path d="M26.9059 5.14589L26.8416 5.16018C28.1495 6.30335 28.9356 7.98953 28.9356 9.72572V23.5795C28.9356 26.8947 26.2341 29.5955 22.918 29.5955H9.05328C8.73883 29.5955 8.37434 29.5597 8.05273 29.5097L8.05988 29.5812C8.39578 29.6383 8.71739 29.6669 9.04614 29.6669H22.8966C26.2556 29.6669 28.9857 26.9376 28.9857 23.5795V9.71857C28.9928 7.94666 28.2424 6.30335 26.9059 5.14589Z"
                                            fill="#B3B3B3"></path>
                                    <path d="M19.1943 12.2909C19.0728 12.1695 18.937 12.1052 18.744 12.1052C18.4867 12.1052 18.2938 12.2266 18.1794 12.4838C17.9221 12.1766 17.5648 12.0337 17.1146 12.0337C16.5714 12.0337 16.1212 12.2481 15.7424 12.6482C15.3636 13.0769 15.1992 13.5699 15.1992 14.1629C15.1992 14.7559 15.385 15.2703 15.7424 15.6776C16.1212 16.1063 16.5714 16.292 17.1146 16.292C17.5648 16.292 17.915 16.1491 18.1794 15.8419C18.3009 16.0991 18.4867 16.2206 18.744 16.2206C18.9298 16.2206 19.0728 16.1491 19.1943 16.0348C19.3158 15.9205 19.3586 15.7776 19.3586 15.5847V12.6768C19.3801 12.5767 19.3086 12.4124 19.1943 12.2909ZM17.9079 14.9131C17.7649 15.0988 17.5505 15.1989 17.2932 15.1989C17.0359 15.1989 16.8215 15.106 16.6786 14.9131C16.5357 14.7273 16.4428 14.4844 16.4428 14.1772C16.4428 13.8914 16.5142 13.6556 16.6786 13.4698C16.8215 13.2841 17.0359 13.184 17.2932 13.184C17.5505 13.184 17.7649 13.2769 17.9079 13.4698C18.0508 13.6556 18.1437 13.8985 18.1437 14.1772C18.1223 14.463 18.0508 14.7345 17.9079 14.9131Z"
                                            fill="#0068FF"></path>
                                    <path d="M20.7665 16.0699C20.645 16.1914 20.5092 16.2557 20.3163 16.2557C20.1305 16.2557 19.9875 16.1842 19.866 16.0699C19.7445 15.9485 19.7017 15.8127 19.7017 15.6198V10.4184C19.7017 10.254 19.7517 10.1111 19.866 9.96825C19.9875 9.84678 20.1233 9.78248 20.3163 9.78248C20.5021 9.78248 20.645 9.85393 20.7665 9.96825C20.888 10.0897 20.9309 10.2255 20.9309 10.4184V15.6198C20.9381 15.8127 20.888 15.9556 20.7665 16.0699Z"
                                            fill="#0068FF"></path>
                                    <path d="M24.8544 12.6696C24.4542 12.2409 23.9539 12.0552 23.3393 12.0552C22.7246 12.0552 22.2315 12.2695 21.8241 12.6696C21.4454 13.0697 21.231 13.5913 21.231 14.2057C21.231 14.8202 21.4168 15.3132 21.8241 15.7419C22.2029 16.142 22.7246 16.3563 23.3393 16.3563C23.9539 16.3563 24.447 16.142 24.8544 15.7419C25.2332 15.3418 25.419 14.8202 25.419 14.2272C25.4547 13.5913 25.2689 13.0769 24.8544 12.6696ZM23.9825 14.9131C23.8395 15.0988 23.6251 15.1989 23.3678 15.1989C23.1106 15.1989 22.8962 15.106 22.7532 14.9131C22.6103 14.7273 22.5174 14.4844 22.5174 14.1772C22.5174 13.8914 22.5888 13.6556 22.7532 13.4698C22.8962 13.2841 23.1106 13.184 23.3678 13.184C23.6251 13.184 23.8395 13.2769 23.9825 13.4698C24.1254 13.6556 24.2183 13.8985 24.2183 14.1772C24.1969 14.463 24.1254 14.7345 23.9825 14.9131Z"
                                            fill="#0068FF"></path>
                                    <path d="M14.5132 12.1976C14.942 11.6332 15.1779 11.2545 15.1779 11.0616C15.1779 10.6114 14.892 10.3757 14.3274 10.3757H11.3257C11.0899 10.3757 10.8969 10.4257 10.7826 10.54C10.6611 10.6615 10.5968 10.7972 10.5968 10.9687C10.5968 11.1544 10.6682 11.2973 10.7826 11.3974C10.9041 11.5188 11.0899 11.5617 11.3257 11.5617H13.384L10.7397 14.9626C10.5753 15.177 10.4824 15.3913 10.4824 15.5557C10.4824 16.0486 10.8112 16.2916 11.4758 16.2916H14.5704C15.0635 16.2916 15.3065 16.0772 15.3065 15.6771C15.3065 15.2484 15.0707 15.0627 14.5704 15.0627H12.2977L14.5132 12.1976Z"
                                            fill="#0068FF"></path>
                                    <path d="M13.0412 19.5572H12.2622V21.1652H13.0412C13.277 21.1652 13.47 21.0938 13.6058 20.9294C13.7487 20.7865 13.8202 20.5721 13.8202 20.3648C13.8202 20.129 13.7487 19.936 13.6058 19.8002C13.47 19.6287 13.2842 19.5572 13.0412 19.5572Z"
                                            fill="#39B54A"></path>
                                    <path d="M16.9001 21.0356C16.6642 21.0356 16.4713 21.1285 16.3355 21.2928C16.1926 21.4787 16.1211 21.6931 16.1211 21.9575C16.1211 22.2219 16.1926 22.4506 16.3355 22.6221C16.4784 22.808 16.6642 22.8794 16.9001 22.8794C17.1359 22.8794 17.3289 22.7865 17.4647 22.6221C17.6076 22.4363 17.6791 22.2219 17.6791 21.9575C17.6791 21.7002 17.6076 21.4644 17.4647 21.2928C17.3146 21.1285 17.1288 21.0356 16.9001 21.0356Z"
                                            fill="#39B54A"></path>
                                    <path d="M22.3389 17.2631H11.147C10.7682 17.2631 10.4609 17.5703 10.4609 17.949V24.4937C10.4609 24.8723 10.7682 25.1796 11.147 25.1796H19.9662C19.8733 25.0867 19.8232 24.9938 19.8232 24.8723C19.8232 24.7795 19.8447 24.6866 19.8947 24.5651L20.3235 23.6434L19.1657 20.7569C19.1443 20.6855 19.1157 20.5926 19.1157 20.4997C19.1157 20.3782 19.1657 20.2639 19.2801 20.1925C19.373 20.0996 19.4945 20.0496 19.6088 20.0496C19.8661 20.0496 20.0376 20.171 20.1305 20.4283L20.8381 22.3931L21.5956 20.4283C21.6885 20.1925 21.8529 20.0496 22.1173 20.0496C22.2388 20.0496 22.3532 20.0996 22.4461 20.1925C22.539 20.2854 22.6105 20.3782 22.6105 20.4997C22.6105 20.5926 22.589 20.6855 22.5604 20.7569L20.8595 24.8938C20.8095 25.0152 20.7666 25.1081 20.6951 25.1796H22.3246C22.7034 25.1796 23.0107 24.8723 23.0107 24.4937V17.949C23.0178 17.5489 22.7034 17.2631 22.3389 17.2631ZM14.4417 21.6572C14.0844 21.9858 13.6413 22.1287 13.1195 22.1287H12.2691V23.3576C12.2691 23.5434 12.219 23.6863 12.1047 23.7863C12.0118 23.8792 11.8689 23.9507 11.7045 23.9507C11.5401 23.9507 11.3972 23.9006 11.3043 23.7863C11.2113 23.6934 11.1399 23.5291 11.1399 23.3576V19.1065C11.1399 18.7064 11.3257 18.5134 11.7331 18.5134H13.0838C13.6484 18.5134 14.0987 18.6778 14.4774 19.0064C14.8348 19.3351 15.0206 19.7852 15.0206 20.3068C15.0063 20.8927 14.8133 21.3214 14.4417 21.6572ZM18.8084 23.3362C18.8084 23.5005 18.7584 23.622 18.644 23.7363C18.5225 23.8578 18.4082 23.9006 18.2438 23.9006C18.0079 23.9006 17.815 23.7792 17.7006 23.5434C17.4648 23.8292 17.136 23.9721 16.7072 23.9721C16.2141 23.9721 15.7853 23.7863 15.4565 23.4076C15.1278 23.029 14.9348 22.5574 14.9348 21.993C14.9348 21.4285 15.0992 20.9784 15.4565 20.5783C15.7853 20.1996 16.2141 20.0139 16.7072 20.0139C17.136 20.0139 17.4433 20.1568 17.7006 20.4425C17.8221 20.2068 17.9865 20.0853 18.2438 20.0853C18.4082 20.0853 18.5511 20.1353 18.644 20.2496C18.7655 20.3711 18.8084 20.4854 18.8084 20.6497V23.3362Z"
                                            fill="#39B54A"></path>
                            </svg>
                            <svg width="32" height="33" viewBox="0 0 32 33" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <mask id="mask0" style="mask-type:alpha" maskUnits="userSpaceOnUse" x="3" y="3"
                                            width="26" height="27">
                                            <path d="M10.6917 3.6665L21.3083 3.6665C23.9829 3.6665 24.9528 3.94498 25.9305 4.4679C26.9083 4.99082 27.6757 5.75819 28.1986 6.73597C28.7215 7.71374 29 8.6836 29 11.3582V21.9748C29 24.6494 28.7215 25.6193 28.1986 26.597C27.6757 27.5748 26.9083 28.3422 25.9305 28.8651C24.9528 29.388 23.9829 29.6665 21.3083 29.6665H10.6917C8.0171 29.6665 7.04724 29.388 6.06946 28.8651C5.09169 28.3422 4.32432 27.5748 3.8014 26.597C3.27848 25.6193 3 24.6494 3 21.9748L3 11.3582C3 8.6836 3.27848 7.71374 3.8014 6.73597C4.32432 5.75819 5.09169 4.99082 6.06946 4.4679C7.04724 3.94498 8.0171 3.6665 10.6917 3.6665Z"
                                                    fill="white"></path>
                                    </mask>
                                    <g mask="url(#mask0)">
                                            <path d="M10.6917 3.6665L21.3083 3.6665C23.9829 3.6665 24.9528 3.94498 25.9305 4.4679C26.9083 4.99082 27.6757 5.75819 28.1986 6.73597C28.7215 7.71374 29 8.6836 29 11.3582V21.9748C29 24.6494 28.7215 25.6193 28.1986 26.597C27.6757 27.5748 26.9083 28.3422 25.9305 28.8651C24.9528 29.388 23.9829 29.6665 21.3083 29.6665H10.6917C8.0171 29.6665 7.04724 29.388 6.06946 28.8651C5.09169 28.3422 4.32432 27.5748 3.8014 26.597C3.27848 25.6193 3 24.6494 3 21.9748L3 11.3582C3 8.6836 3.27848 7.71374 3.8014 6.73597C4.32432 5.75819 5.09169 4.99082 6.06946 4.4679C7.04724 3.94498 8.0171 3.6665 10.6917 3.6665Z"
                                                    fill="#A50064"></path>
                                            <path d="M21.1624 8.6665C19.0427 8.6665 17.3247 10.2823 17.3247 12.2755C17.3247 14.269 19.0427 15.8849 21.1624 15.8849C23.2819 15.8849 25 14.269 25 12.2755C25 10.2823 23.2819 8.6665 21.1624 8.6665ZM21.1624 13.8159C20.2632 13.8159 19.5325 13.1289 19.5325 12.2833C19.5325 11.4376 20.2632 10.7505 21.1624 10.7505C22.0615 10.7505 22.7922 11.4376 22.7922 12.2833C22.7922 13.1289 22.0615 13.8161 21.1624 13.8161V13.8159ZM16.2168 15.8927H14.0089V11.3546C14.0089 11.0148 13.7198 10.7433 13.3587 10.7433C12.9974 10.7433 12.7083 11.0148 12.7083 11.3546V15.8927H10.5006V11.3546C10.5006 11.0148 10.2117 10.7433 9.85038 10.7433C9.48906 10.7433 9.19994 11.0148 9.19994 11.3546V15.8927H7V11.3772C7 9.8822 8.29262 8.6665 9.88225 8.6665C10.5325 8.6665 11.1267 8.87041 11.6084 9.21008C12.1645 8.84769 12.7399 8.6665 13.3345 8.6665C14.9241 8.6665 16.2168 9.8822 16.2168 11.3772V15.8927ZM21.1624 17.4481C19.0427 17.4481 17.3247 19.0638 17.3247 21.0571C17.3247 23.0506 19.0427 24.6665 21.1624 24.6665C23.2819 24.6663 25 23.0504 25 21.0571C25 19.0638 23.2819 17.4479 21.1624 17.4479V17.4481ZM13.3345 17.4397C14.9241 17.4397 16.2168 18.6554 16.2168 20.1504V24.6659H14.0089V20.1279C14.0089 19.788 13.7198 19.5165 13.3587 19.5165C12.9974 19.5165 12.7083 19.788 12.7083 20.1279V24.6659H10.5006V20.1279C10.5006 19.788 10.2117 19.5165 9.85038 19.5165C9.48906 19.5165 9.19994 19.788 9.19994 20.1279V24.6659H7V20.1504C7 18.6554 8.29262 17.4397 9.88225 17.4397C10.5325 17.4397 11.1267 17.6437 11.6084 17.9833C12.1645 17.6209 12.7399 17.4397 13.3345 17.4397ZM21.1624 19.532C22.0615 19.532 22.7922 20.2191 22.7922 21.0649C22.7922 21.9104 22.0615 22.5975 21.1624 22.5975C20.2632 22.5975 19.5325 21.9104 19.5325 21.0649C19.5325 20.2191 20.2632 19.532 21.1624 19.532Z"
                                                    fill="white"></path>
                                    </g>
                            </svg>
            
                    </div>

                    <div class="contact">
                            <p>Liên hệ với chúng tôi</p>
                            <div class="icon">
                                    <a href="https://www.facebook.com/" class="facebook"><i
                                                    class="fa-brands fa-square-facebook item-icon-application"></i></a>
                                    <a href="https://twitter.com/" class="twitter"><i class="fa-brands fa-twitter item-text-application"></i></a>
                                    <a href="https://www.youtube.com/" class="youtube"><i
                                                    class="fa-brands fa-youtube item-sub-application"></i></a>
                                    <a href="https://www.instagram.com/" class="instagram"> <i
                                                    class="fa-brands fa-instagram item-nav-application"></i></a>
            
                            </div>
                    </div>
                    
                    <div class="download">
                            <h3 class="text1">Tải ứng trên điện thoại</h3>
                            <img src="https://frontend.tikicdn.com/_desktop-next/static/img/icons/appstore.png"
                                    alt="app-store" class="app-store">
                            <img src="https://frontend.tikicdn.com/_desktop-next/static/img/icons/playstore.png"
                                    alt="google-play" class="ch-play">
                            <img src="https://frontend.tikicdn.com/_desktop-next/static/img/footer/qrcode.png"
                                    alt="qr-code" class="qr-code">
                    </div>
            </div>
            
    </div>
    <hr>


    <div class="footer-b">
        <div>
                <p class="text4">
                        © 2019 Đại học HUFI
                        Đại học HUFI TPHCM. 140 Lê Trọng Tấn, Phường Tây Thạnh, Quận Tân Phú, TP.HCM
                        Điện thoại: (+84-24) 38272289. Fax: (+84-24) 38722375.
                        Giấy chứng nhận đăng ký doanh nghiệp, mã số doanh nghiệp: 0100107518, đăng ký
                        lần đầu ngày 30/6/2010, đăng ký thay đổi lần thứ 9 ngày 12/01/2022, cấp bởi Sở
                        thành phố HCM.
                </p>
                <div class="footer-img">
                    <img src="https://d3jyiu4jpn0ihr.cloudfront.net/wp-content/uploads/sites/3/20181009101343/bambooairways-dathongbaobocongthuong.png"
                    alt="tb-bo-cong-thuong" class="thong-bao">
                    <img src="https://frontend.tikicdn.com/_desktop-next/static/img/footer/bo-cong-thuong.svg"
                            alt="dk-bo-cong-thuong" class="dang-ki">
                </div>
        </div>
    </div>
</div>
    `)
}


function addFooter_mini(){
    document.write(`
    <div class="mini_footer">
        <div>
            <p class="text4">
                    © 2019 Đại học HUFI
                    Đại học HUFI TPHCM. 140 Lê Trọng Tấn, Phường Tây Thạnh, Quận Tân Phú, TP.HCM
                    Điện thoại: (+84-24) 38272289. Fax: (+84-24) 38722375.
                    Giấy chứng nhận đăng ký doanh nghiệp, mã số doanh nghiệp: 0100107518, đăng ký
                    lần đầu ngày 30/6/2010, đăng ký thay đổi lần thứ 9 ngày 12/01/2022, cấp bởi Sở
                    thành phố HCM.
            </p>
            <div class="mini_footer-img">
                <img src="https://d3jyiu4jpn0ihr.cloudfront.net/wp-content/uploads/sites/3/20181009101343/bambooairways-dathongbaobocongthuong.png"
                        alt="tb-bo-cong-thuong" class="">
                <img src="https://frontend.tikicdn.com/_desktop-next/static/img/footer/bo-cong-thuong.svg"
                        alt="dk-bo-cong-thuong" class="">

            </div>
        </div>
    </div>
    `)
}

// sản phẩm
function ScrollTop() {
    if (window.jQuery) {
        jQuery('html,body').animate({
            scrollTop: 0
        }, 100);
    } else {
        document.getElementsByClassName('top-nav')[0].scrollIntoView({
            behavior: 'smooth',
            block: 'start'
        });
        document.body.scrollTop = 0; // For Safari
        document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
    }
    
}

