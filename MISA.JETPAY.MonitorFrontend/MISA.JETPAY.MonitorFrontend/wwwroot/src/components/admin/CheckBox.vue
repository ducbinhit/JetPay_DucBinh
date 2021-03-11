 <template>
  <el-checkbox
    v-model="isCheck"
    @change="handleClickCheckBox(id)"
  ></el-checkbox>
</template>
 
 <script>
import { mapGetters, mapActions } from "vuex";
export default {
  name: "check-box",
  props: {
    id: String,
  },
  computed: {
    ...mapGetters(["allItemClicked", "listItems","paginateInfo"]),
  },
  data() {
    return {
      isCheck: false,
    };
  },
  methods: {
    ...mapActions(["deleteListItem", "setAllItemClicked"]),
    /**
     * Sự kiện click checkBox
     * Author: NCBAO(18/12/2020)
     */
    handleClickCheckBox(id) {
      this.$emit("handleClickCheckBox", id);
      if (this.listItems.length == 0) {
        this.setAllItemClicked(false);
        this.$emit("setSetAllItemClicked", false);
      }
    },
  },
  watch: {
    allItemClicked: function (newAllItemClicked) {
      if (this.allItemClicked) this.isCheck = newAllItemClicked;
      else {
        this.isCheck = newAllItemClicked;
        this.deleteListItem();
      }
    }
  },
};
</script>
 
 <style>
</style>