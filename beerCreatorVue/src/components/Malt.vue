<script>
export default {
  data() {
    return {
      maltName: '',
      description: '',
      color: '',
      extract: ''
    }
  }
}
</script>

<template>
  <table class="table">
    <tbody>
      <tr>
        <td><input v-model="maltName" placeholder="Наименование" size="30"></td>
      </tr>
      <tr>
        <td><textarea v-model="description" placeholder="Описание" size="120"></textarea></td>
      </tr>
      <tr>
        <td><input v-model="color" placeholder="Цветность" size="9"></td>
      </tr>
      <tr>
        <td><input v-model="extract" placeholder="Экстрактность" size="13"></td>
      </tr>
    </tbody>
    <input type="submit" value="Сохранить" @click="send()">
  </table>
</template>

<style scoped>
.table {
	width: 100%;
	margin-bottom: 20px;
	border: 1px solid #ffffff;
	border-collapse: collapse; 
}
.table th {
	font-weight: bold;
	padding: 5px;
	background: #ffffff;
	border: 1px solid #ffffff;
}
.table td {
	border: 1px solid #000000;
	padding: 5px;
}
</style>