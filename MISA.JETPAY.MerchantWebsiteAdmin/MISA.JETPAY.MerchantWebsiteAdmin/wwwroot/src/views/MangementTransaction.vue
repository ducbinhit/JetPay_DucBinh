<template>
  <div class="main">
    <SlideBar />
    <div class="main-right">
      <Header />
      <div class="transaction-details">
        <div class="title">Quản lý giao dịch thanh toán</div>
        <div class="line"></div>
        <!-- transaction content -->
        <div class="transaction-content">
          <!-- btn group -->
          <div class="btn-group">
            <button
              type="button"
              class="dropdown-toggle select-office"
              data-toggle="dropdown"
              aria-expanded="false"
              id="button-search-department"
            >
              Tháng này
              <i class="fas fa-caret-down"></i>
            </button>
            <div class="dropdown-menu" id="data-department"></div>
          </div>
          <!-- and btn group -->
          <!-- group money -->
          <div class="group-money">
            <div class="money-left">
              <div class="m-col">
                <div class="m-icon">Σ</div>
                <div class="m-text">Tiền hàng:</div>
                <div class="m-money">100.000.000</div>
              </div>
              <div class="m-col">
                <div class="m-icon">Σ</div>
                <div class="m-text">Giảm giá:</div>
                <div class="m-money">100.000.000</div>
              </div>
              <div class="m-col">
                <div class="m-icon">Σ</div>
                <div class="m-text">Phí giao dịch:</div>
                <div class="m-money">100.000.000</div>
              </div>
              <div class="m-col">
                <div class="m-icon">Σ</div>
                <div class="m-text">Tiền thanh toán:</div>
                <div class="m-money">100.000.000</div>
              </div>
            </div>
            <div class="money-right">
              <div class="m-col m-col1">
                <div class="m-text">Đơn vị:</div>
                <div class="m-money">VNĐ</div>
              </div>
            </div>
          </div>
          <!-- end group money -->
        </div>
        <!-- data table -->
        <div class="data-table">
          <div class="loader"></div>
          <table class="table">
            <colgroup>
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
            </colgroup>
            <thead>
              <tr>
                <th width="50px" fieldName="">STT</th>
                <th width="150px" fieldName="">Ngày thanh toán</th>
                <th width="150px" fieldName="">Ngày đơn hàng</th>
                <th width="150px" fieldName="">Mã giao dịch</th>
                <th width="150px" fieldName="">Mã đơn hàng</th>
                <th width="200px" fieldName="">Tên khách hàng</th>
                <th width="120px" fieldName="">Số điện thoại</th>
                <th width="300px" fieldName="">Email</th>
                <th width="200px" fieldName="">Địa chỉ</th>
                <th width="100px" fieldName="">Loại thẻ</th>
                <th width="200px" fieldName="">Chủ thẻ</th>
                <th width="150" fieldName="">Loại tiền</th>
                <th width="150" fieldName="">Tiền hàng</th>
                <th width="150" fieldName="">Giảm giá</th>
                <th width="200px" fieldName="">Phí giao dịch</th>
                <th width="150" fieldName="">Tổng tiền</th>
                <th width="150" fieldName="">Trạng thái</th>
                <th width="150" fieldName="">Setting</th>
              </tr>
            </thead>
            <tbody id="render-data">
              <tr class="filter-data">
                <td>
                  <input style="width: 35px" type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input style="width: 200px" type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
                <td>
                  <input type="text" />
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lý</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lýyyy</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lýyyy</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lýyyy</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lýyyy</span>
                </td>
              </tr>
              <tr>
                <td>
                  <span>01</span>
                </td>
                <td>
                  <span>18/03/2021</span>
                </td>
                <td>
                  <span>20/03/2021</span>
                </td>
                <td>
                  <span>123456</span>
                </td>
                <td>
                  <span>654321</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>0366666666</span>
                </td>
                <td>
                  <span>ndbinh@gmail.com</span>
                </td>
                <td>
                  <span>Sóc Sơn, Hà Nội</span>
                </td>
                <td>
                  <span>VISA</span>
                </td>
                <td>
                  <span>Nguyễn Đức Bình</span>
                </td>
                <td>
                  <span>1234 4321 4567 6543</span>
                </td>
                <td>
                  <span>VNĐ</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>100.000.000</span>
                </td>
                <td>
                  <span>Đang xử lýyyy</span>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
        <!-- end data table -->
        <div class="paging-bar">
          <div class="paging-left">Hiển thị 1-10/120 Khách hàng</div>
        </div>
        <!-- end transaction content -->
      </div>
    </div>
  </div>
</template>

<script>
import Header from "../components/Header.vue";
import SlideBar from "../components/SlideBar.vue";
export default {
  components: { Header, SlideBar },
};
</script>

<style>
* {
  margin:0;
  padding: 0;
}
.main {
  background-color: antiquewhite;
  display: flex;
}
.main-right {
  width: calc(100% - 250px);
  min-width: 1116px;
}
.transaction-details {
  padding-top: 14px;
  padding-left: 20px;
  padding-right: 20px;
  font-family: "GoogleSans Regular";
  border: 1px solid #74757c;
}
.line {
  margin-top: 17px;
  margin-bottom: 14px;
}
.title {
  font-family: "GoogleSans Bold";
  font-size: 16px;
}
.content-title {
  font-family: "GoogleSans Bold";
  font-size: 14px;
}
.transaction-details {
  /* width: calc(100% - 250px);
  min-width: 1116px; */
  background-color: #ffffff;
}
.line {
  border-bottom: 1px solid #d9dade;
}

/* css cho group money */
.group-money {
  display: flex;
  font-size: 14px;
  align-items: center;
  margin-top: 16px;
  justify-content: space-between;
}
.money-left {
  display: flex;
}
.m-col {
  display: flex;
  align-items: center;
  margin-right: 28px;
}
.m-col1 {
  margin-right: 0;
}
.m-col .m-icon {
  font-size: 20px;
  color: #74757c;
}
.m-col .m-text {
  color: #74757c;
  margin-right: 8px;
  margin-left: 3px;
}
/**
Css cho data-table
*/
.data-table {
  height: calc(100vh - 237px);
  overflow: scroll;
  margin-top: 12px;
  overflow-x: auto;
}

.data-table .table {
  width: 1300px;
  border-spacing: 0px;
  table-layout: fixed;
  border-collapse: separate;
}

.data-table .table tr {
  height: 40px;
}
.data-table .table tr input {
  border: 1px solid #d9dade;
  height: 32px;
  border-radius: 5px;
  width: 100px;
}

tbody tr:nth-child(2n + 1) {
  background-color: #fafafa;
}

tbody tr:hover {
  background-color: #d9d9d9;
  cursor: pointer;
}
.data-table .table tr th {
  border-bottom: 1px solid #bbbbbb;
  text-align: left;
  border-top: none;
  position: sticky;
  top: 0;
  font-size: 14px;
  z-index: 5;
  background-color: #d9dade;
}

.data-table .table tr td {
  text-align: left;
  border: none;
  font-size: 14px;
  border-bottom: 1px solid #bbbbbb;
  height: 40px;
  color: #292b35;
}

.data-table .table tr:hover td {
  background-color: #ddd;
  cursor: pointer;
}

.data-table .table tr .employee-coefficient {
  width: 140px;
  text-align: right;
  padding-right: 10px;
}
.paging-bar {
  display: flex;
  height: 40px;
  background-color: #ffffff;
  justify-content: space-between;
  width: 100%;
}
</style>
