export default {
  methods: {
    /**
     * Hàm format Date
     * @param {string} date
     * Author: LTQuan (11/12/2020)
     */
    formatDate: date => {
      return !date
        ? ""
        : date
            .split("T")[0]
            .split("-")
            .reverse()
            .join("/");
    },
    /**
     * Hàm format giá tiền
     * @param {Number} amount
     * Author: LTQuan (14/12/2020)
     */
    formatCurrency: amount => {
      return !amount
        ? ""
        : (amount + "")
            .replace(/\D/g, "")
            .replace(/\B(?=(\d{3})+(?!\d))/g, ".");
    },
    /**
     * Format định dạng ngày về yyyy-mm-dd T hh:mm:ss
     * @param {date} date
     * Author: LTQUAN (11/12/2020)
     */
    formatDateTime(date) {
      if (date)
        return `${date.getFullYear()}-${date.getMonth() +
          1}-${date.getDate()}T${this.padLeft(
          date.getHours(),
          2
        )}:${this.padLeft(date.getMinutes(), 2)}:${this.padLeft(
          date.getSeconds(),
          2
        )}`;
      return null;
    },
    /**
     * Xử lý format chuỗi theo chuẩn length tuyền vào
     * @param {str} String
     * @param {max} Number
     * Author: LTQUAN (11/12/2020)
     */
    padLeft(str, max) {
      str = str.toString();
      return str.length < max ? this.padLeft("0" + str, max) : str;
    }
  }
};
