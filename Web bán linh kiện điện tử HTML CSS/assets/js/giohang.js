

var giohang = new Array();

function addCart(x){
    var boxsp = x.parentElement.parentElement.children[0]; //a.product-item
    var hinh = boxsp.children[0].children[0].src;
    var tensp = boxsp.children[1].innerText;
    var giasp = parseInt(boxsp.children[3].children[0].innerText);
    var soluong = 1;
    var sp = new Array(hinh , tensp, soluong, giasp);

    //kiemtra gio hang
    var kt=0;
    for(let i =0;i<giohang.length;i++){
        if(giohang[i][1] == tensp){
            kt=1;
            soluong+=parseInt(giohang[i][2]);
            giohang[i][2] = soluong;
            break;
        }
    }
    if(kt==0){
        giohang.push(sp);

    }
    alert("Đã thêm sản phẩm vào giỏ hàng");
    sessionStorage.setItem("giohang", JSON.stringify(giohang));
}

function addToCart(x){
    var boxsp = x.parentElement.parentElement; //row
    var hinh = boxsp.children[0].children[0].src;
    var tensp = boxsp.children[1].children[1].innerText;
    var giasp = (boxsp.children[1].children[2].children[1].innerText);
    var soluong = (boxsp.children[1].children[3].children[0].value);
    var sp = new Array(hinh , tensp, soluong ,giasp);
    giohang.push(sp);
    alert("Đã thêm sản phẩm vào giỏ hàng");
    sessionStorage.setItem("giohang", JSON.stringify(giohang));
    showCountSp();
}

// function showCountSp(){
//     document.getElementById("countsp").innerHTML = giohang.length;
// }

function giamSoLuong(tensp) {
	for (var p of sp) {
		if (p.ten == tensp) {
			if (p.soluong > 1) {
				p.soluong--;
			} else {
				return;
			}
		}
	}
    location.reload();
}
function tangSoLuong(tensp) {
	for(let i =0;i<giohang.length;i++) {
		if(giohang[i][1] == tensp){
            kt=1;
            soluong+=parseInt(giohang[i][2]);
            giohang[i][2] = soluong;
            break;
        }else {
            alert("Chỉ được mua tối đa 3 sản phẩm");
            return;
        }
	}
    location.reload();
}


//trang giohang
function showCart() {
    var gh = sessionStorage.getItem("giohang");
    var giohang = JSON.parse(gh);
    var ttgh = "";
    var tong=0;
    if (giohang.length == 0) {
		ttgh += `
			<tr>
				<td colspan="7"> 
					<h1 style="color:green; background-color:white; font-weight:bold; text-align:center; padding: 15px 0;">
						Giỏ hàng trống !!
					</h1> 
				</td>
			</tr>
		`;
		document.getElementById("myCart").innerHTML  = ttgh;
		return;
	}
    
    for(let i = 0; i < giohang.length; i++){
        var thanhtien = parseInt(giohang[i][2] * giohang[i][3]);
        
        tong +=thanhtien;
        ttgh+=' <tr class="row-sp"> '+
                    '<td>'+(i + 1)+'</td>'+
                    '<td style="text-align: center" ><img src="'+giohang[i][0]+'"></td>'+
                    '<td class="row-height">'+giohang[i][1]+'</td>'+
                    '<td class="alignCenter">'+giohang[i][3]+'</td>'+
                    '<td class="soluong" >'+
                        '<button onclick="giamSoLuong('+giohang[i][1]+')">'+ '<i class="fa fa-minus">'+'</i>'+ '</button>'+
                        '<input size="1" value= "'+ giohang[i][2] +'" >'+
                        '<button onclick="tangSoLuong('+giohang[i][1]+')">'+ '<i class="fa fa-plus"></i>'+ '</button>'+
                    '</td>'+
                    '<td class="alignCenter">'+ thanhtien +'</td>'+
                    '<td class="noPadding"> <i class="fa fa-trash" onclick="xoaSanPhamTrongGioHang(` + i + `)"></i> </td>'+
                '</tr>';
    }
    ttgh +='<tr style="font-weight:bold; text-align:center">'+
                '<td colspan="4">TỔNG TIỀN: </td>'+
                '<td class="">'+ tong +'</td>'+
                '<td class="thanhtoan"> <a href="./trangthanhtoan.html">Thanh Toán</a> </td>'+
                '<td class="xoaHet" onclick="xoaHet()"> Xóa hết </td>'+
            '</tr>';

    document.getElementById("myCart").innerHTML  = ttgh;

}

function xoaHet(){
    var gh = sessionStorage.getItem("giohang");
    var giohang = JSON.parse(gh);
    if (window.confirm('Bạn có chắc chắn muốn xóa hết sản phẩm trong giỏ !!')){
        giohang.length = 0;
    }
    else{
        return;
    }    
    sessionStorage.setItem("giohang", JSON.stringify(giohang));
    location.reload();
}
function thanhToan(){
    var gh = sessionStorage.getItem("giohang");
    var giohang = JSON.parse(gh);
    if (window.confirm('Xác nhận thanh toán !!')){
        giohang.length = 0;
        alert('Đơn hàng đã được gửi đi và đang chờ xử lý!')
    }
    else{
        return;
    }    
    sessionStorage.setItem("giohang", JSON.stringify(giohang));
    location.replace("GioHang.html");
}

showCart();