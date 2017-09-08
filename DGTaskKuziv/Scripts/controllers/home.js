
    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: "/Home/Data",
                dataType: "json"
            }
        }
    });

    $("#multiselect").kendoMultiSelect({
        dataSource: dataSource,
        dataTextField: "CurrentDate",
        dataValueField: "Id",
        animation: {
            close: {
                effects: "fadeOut zoom:out",
                duration: 300
            },
            open: {
                effects: "fadeIn zoom:in",
                duration: 300
            }
        },
        dataBound: function (e) {
            var data = this.dataSource.data().map(function (e) { return e.Id; });
            this.value(data);
        }
    });


$('#dateDiagram').submit(function (e) {
    e.preventDefault();
    var dataSource1 = $($('#multiselect').data('kendoMultiSelect').dataSource.data()).toArray();
    var data = $('#multiselect').data('kendoMultiSelect').value();
    var dataSource = [];
    for (var i = 0; i < data.length; i++) {
        var idx = dataSource1.findIndex(function (e) { return e.Id === data[i]; });
        var dataitem = $('#multiselect').data('kendoMultiSelect').dataItem(idx);
        dataitem.idx = idx;
        dataSource.push(dataitem);
    }
    dataSource.sort(function (a, b) { return a.idx - b.idx; });
    createChart(dataSource);   
});
function createChart(dataSource)
{

        $("#chart").kendoChart({
            dataSource: dataSource,
            
                  title: {
                  text: "The average value of the size of the cancerous tumor"
            },
            legend: {
                position: "top"
            },
            seriesDefaults: {
                type: "line"
            },
            series: [{                
                field: "Average",
                name: "Average"
            }],
            categoryAxis: {
                field: "CurrentDate",
                labels: {
                    rotation: -90
                },
                crosshair: {
                    visible: true
                }
            },
            valueAxis: {
                labels: {
                    format: "N0"
                },
                majorUnit: 2
            },
            tooltip: {
                visible: true,
                shared: true,
                format: "##.#####"
            }
        });    
}
createChart();