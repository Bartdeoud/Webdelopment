<form method="post" action="https://fakepay.azurewebsites.net/">
<input type="hidden" name="amount" value={props.bedrag}></input>
<input type="hidden" name="url" value="https://localhost:7214/api/Pay"></input>
<input type="hidden" name="reference" value={ref}></input>
<button className="btn" type="onsubmit">Betaal!</button>
</form>