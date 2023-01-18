
import React, { useEffect, useState }  from 'react'
import axios from 'axios';


function ProductList() {

    const[productarr,setproductarr]=useState([]);

    useEffect(()=>{
        axios.get('http://localhost:5241/products')
        .then(resp=>{
            setproductarr(resp.data)
        })
        .catch(err=>{
            console.log(err)
        })

    },[])
  

  return (
   
    <div>
        <table align='center' >
        <ol>
        <th>
                <tr>
                    <td>Id</td>
                    <td>Name</td>
                    <td>Price</td>
                </tr>
            </th>
        
        {
           
            productarr.map(prod=>
            <tr><li key={prod.id}>
            <td>{prod.id}</td>
            <td>{prod.name}</td>
            <td>{prod.price}</td></li></tr>)
        }
        </ol>
        </table>
    </div>
  )
}

export default ProductList
