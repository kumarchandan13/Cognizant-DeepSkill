import { courses } from "./courses";

function CourseDetails() {

    return (

        <div>

            <h1>Course Details</h1>

            {
                courses.map(course => (

                    <div key={course.id}>

                        <h2>{course.cname}</h2>

                        <h5>{course.date}</h5>

                    </div>

                ))
            }

        </div>

    );

}

export default CourseDetails;