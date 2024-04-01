document.addEventListener("DOMContentLoaded", function () {
  var table = document.getElementById("linkTable");
  var rows = table.getElementsByTagName("tr");
  for (var i = 0; i < rows.length; i++) {
    var row = rows[i];
    row.addEventListener("click", function () {
      var href = this.getAttribute("data-href");
      if (href) {
        window.location.href = href;
      }
    });
  }
});
