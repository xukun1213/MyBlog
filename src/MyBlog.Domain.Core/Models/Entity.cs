namespace MyBlog.Domain.Core.Models
{
    /// <summary>
    /// 领域实体基类
    /// </summary>
    public abstract class Entity
    {
        public int Id { get; protected set; }

        /// <summary>
        /// 重写Equals方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;
            if (ReferenceEquals(this, compareTo)) return true;
            if (compareTo is null) return false;

            return Id.Equals(compareTo.Id);
        }
        /// <summary>
        /// 重写操作符 ==
        /// </summary>
        /// <param name="a">实体a</param>
        /// <param name="b">实体b</param>
        /// <returns></returns>
        public static bool operator ==(Entity a, Entity b)
        {
            if (a is null || b is null)
                return false;
            if (a is null && b is null)
                return true;
            return a.Equals(b);
        }
        /// <summary>
        /// 重写操作符 !=
        /// </summary>
        /// <param name="a">实体a</param>
        /// <param name="b">实体b</param>
        /// <returns></returns>
        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }
        /// <summary>
        /// 重写GetHashCode()，获取哈希值
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
        /// <summary>
        /// 重写ToString(),输出领域对象的状态
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}
