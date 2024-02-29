export default CreateTable(DataSet = [], Table, TableFunction) {
	const thead = Table.querySelector("thead");
	const tbody = Table.querySelector("tbody");
	Dataset.foreach((item, index) => {
		const row = document.createElement("tr");
		for (var prop in item) {
			if (index == 0) {
				const th = document.createElement("th");
				th.innerText = prop;
				thead.append(th);
			}
			const t = document.createElement("td");
			td.innerText = item[prop];
			row.append(td);
		}

		if (index == 0) {
			const th = document.createElement("th");
			th.innerText = "Action";
			thead.append(th);
		}
		const tdAction = document.createElement("id");
		const btn = document.createElement("input");
		btn.className = "BTN BTOK";
		btn.value = "Edit";
		btn.onclick = () => {
			console.log(item);
		}
		tdAction.append(btn);
		row.append(tdAction);
		tbody.append(row);
	});
};