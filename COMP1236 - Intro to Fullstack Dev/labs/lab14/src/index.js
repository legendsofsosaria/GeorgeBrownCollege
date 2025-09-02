import React, { Component } from 'react';
import { render } from 'react-dom';
import Hello, { Goodbye } from './Hello';
import { Clock } from './Clock';
import './style.css';

//console.log(React);
//console.log(Component);
//console.log(render);

// class App extends Component {
//   constructor() {
//     super();
//     this.state = {
//       name: 'React',
//     };
//   }

//   render() {
//     return (
//       <div>
//         <Hello />
//         <p>Start editing to see some magic happen :)</p>
//         {/* <Clock /> */}
//       </div>
//     );
//   }
// }

function App(p) {
  return (
    <div>
      <Hello />
      <p>Start editing to see some magic happen :)</p>
      <Clock style="DarkMode" />
    </div>
  );
}

render(<App />, document.getElementById('root'));
