<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<title>Selecting an Element by Index in jQuery</title>
<style type="text/css">
    .highlight{
        background: yellow;
    }        
</style>
<script src="https://code.jquery.com/jquery-1.12.4.min.js"></script>
<script type="text/javascript">
$(document).ready(function(){
    $("ul li").eq(1).addClass("highlight");
});
</script>
</head>
<body>
	<h2>Unordered List</h2>
    <ul>
        <li>First list item</li>
        <li>Second list item</li>
        <li>Third list item</li>
        <li>Fourth list item</li>
    </ul>
	<hr>
	<h2>Another Unordered List</h2>
	<ul>
        <li>First list item</li>
        <li>Second list item</li>
        <li>Third list item</li>
        <li>Fourth list item</li>
    </ul>
</body>
</html>                            