<script>        
    (function (){
        var conv = new showdown.Converter();
        var txt = document.getElementById('article').innerHTML;              
        document.getElementById('article').innerHTML = conv.makeHtml(txt);
    })();
</script>