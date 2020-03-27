am4core.ready(function () {

    // Themes begin
    am4core.useTheme(am4themes_animated);
    // Themes end

    var chart = am4core.create("chartdiv_5", am4charts.PieChart);
    chart.hiddenState.properties.opacity = 0; // this creates initial fade-in

    chart.data = [
      {
          country: "Furniture and home furnishings",
          value: "9.80"
      },
      {
          country: "Nonmerchandise receipts3",
          value: "8.95"
      },
      {
          country: "Electronics and appliances",
          value: "8.84"
      },
      {
          country: "Drugs, health aids, and beauty aids",
          value: "7.28"
      },
      {
          country: "Computer hardware",
          value: "5.92"
      },
      {
          country: "Sporting Goods",
          value: "3.96"
      },
    {
        country: "Books and magazines",
        value: "3.95"
    },
        {
            country: "Toys, hobby goods, and games",
            value: "3.62"
        },
         {
             country: "Food, beer, and wine",
             value: "2.57"
         },
  {
      country: " Other merchandise2",
      value: "17.94"
  },
{
    country: "Clothing and clothing accessories (includes footwear)",
    value: "17.68"
},
{
    country: "Total Electronic Shopping and Mail-Order Houses (NAICS 45411)",
    value: "100.00"
},



{
    country: "Office equipment and supplies",
    value: "3.13"
}





    ];
    chart.radius = am4core.percent(70);
    chart.innerRadius = am4core.percent(40);
    chart.startAngle = 180;
    chart.endAngle = 360;

    var series = chart.series.push(new am4charts.PieSeries());
    series.dataFields.value = "value";
    series.dataFields.category = "country";

    series.slices.template.cornerRadius = 10;
    series.slices.template.innerCornerRadius = 7;
    series.slices.template.draggable = true;
    series.slices.template.inert = true;
    series.alignLabels = false;

    series.hiddenState.properties.startAngle = 90;
    series.hiddenState.properties.endAngle = 90;

    chart.legend = new am4charts.Legend();

}); // end am4core.ready()