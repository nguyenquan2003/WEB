<ul id=menu>
	<li><a href="index.php">Trang chủ</a></li>
	<li><a href="san-pham.html">Sách</a></li>
	<li><a href="user.html">User</a></li>
	<li><a href="">Menu 4</a></li>
	<li><a href="">Menu 5</a></li>
	<?php
	if (isset($_SESSION['user_login']))
	{
		?>
		<li><a href="">Chào: <?php echo $_SESSION['user_login']['name'] ?></a></li>
		<li><a href="logout.html">Đăng xuất </a></li>
		<?php
	}
	else
		{
			?>
			<li><a href="login.html">Đăng nhập</a></li>
			<li><a href="#">Đăng ký</a></li>
		<?php
		}
		?>
</ul>
