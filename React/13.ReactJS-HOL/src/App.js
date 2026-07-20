import './App.css';

import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {

  const show = true;

  return (

    <div
      style={{
        display: "flex",
        justifyContent: "space-around",
        marginTop: "50px"
      }}
    >

      {show && <CourseDetails />}

      {show ? <BookDetails /> : null}

      <BlogDetails />

    </div>

  );

}

export default App;