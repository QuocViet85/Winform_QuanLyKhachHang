# Ham thao tac tren gridView:
- fg.GetIntValue(rowindex, ten cot);
- fb[rowIndex, ten cot];

# Thuộc tính Anchor của các control để control neo vào các hướng 
=> Có thể dùng Anchor để GridView to ra khi cửa sổ to ra.

# DataRow và Row:
- Đối tượng DataRow là đối tượng có sẵn trong đối tượng có sẵn DataTable.
- Đối tượng Row là đối tượng tự tạo trong đối tượng tự tạo fg.Rows.
* Ô trống:
- Ô trống trong DataRow có giá trị là object bọc chuỗi rỗng và có thể convert thành chuỗi rỗng.
- Ô trống trong Row có giá trị là null

# Thao tác với đối tượng Row:
- Thao tác gán giá trị ô của Row bằng fg chứ không bằng row.
- Thao tác lấy giá trị ô của Row bằng fg hoặc bằng row.

# Lấy giá trị ô từ fg:
- fg[index dòng, tên cột]
- fg.Rows[index dòng][tên cột]
- 1 số hàm lấy và có thể tự động chuyển kiểu dữ liệu: fg.tenHam(index dòng, tên cột)

# Combobox:
- Combobox chỉ có SelectedValue nếu có DataSource.
- Nếu combox.DataSource = null => combobox không có SelectedValue, chỉ có Text.
